using Assets.Scripts;
using Newtonsoft.Json;
using System;
using System.IO;
using UnityEngine;

public class Player : Actor
{
    string savePath = "Saves\\";
    string saveName = "game.json";

    [Serializable]
    public class GameData
    {
        public PlayerData PlayerData { get; set; }
    }

    [Serializable]
    public class PlayerData
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public int CurrentHealth { get; set; }
    }

    public void Update()
    {
        if(Input.GetKey(KeyCode.F5))
        {
            GameData gameData = new GameData();

            gameData.PlayerData = new PlayerData
            {
                X = this.transform.position.x, 
                Y = this.transform.position.y, 
                Z = this.transform.position.z,
                CurrentHealth = this.currentHealth
            };
            
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }

            using (var stream = File.CreateText($"{savePath}{saveName}"))
            {
                string json = JsonConvert.SerializeObject(gameData, Formatting.Indented);
                stream.Write(json);
            }
        }else if (Input.GetKey(KeyCode.F9))
        {
            if (File.Exists($"{savePath}{saveName}"))
            {
                var json = File.ReadAllText($"{savePath}{saveName}");

                var gameData = JsonConvert.DeserializeObject<GameData>(json);
                this.currentHealth = gameData.PlayerData.CurrentHealth;
                healthBar.SetHealth(currentHealth);

                this.gameObject.transform.position = new Vector3(gameData.PlayerData.X, gameData.PlayerData.Y, gameData.PlayerData.Z);
            }
        }
    }

    public void GetHealthByDrinkOrEat(int health)
    {
        currentHealth += health;
        if (currentHealth >= 100)
        {
            currentHealth = 100;
            healthBar.SetHealth(maxHealth);
        }
        healthBar.SetHealth(currentHealth);

    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            TakeDamage(5);

            var attack = Input.GetKey(KeyCode.H);

            if (attack)
            {
                other.gameObject.GetComponent<Enemy>().TakeDamage(5);
            }
        }

       
    }
}
