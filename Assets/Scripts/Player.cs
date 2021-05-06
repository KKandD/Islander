using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {

    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
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
}
