using Assets.Scripts;
using UnityEngine;

public class Player : Actor
{
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
