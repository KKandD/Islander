using UnityEngine;

namespace Assets.Scripts
{
    public class Actor: MonoBehaviour
    {
        public int maxHealth = 100;
        public int currentHealth;
        public HealthBar healthBar;

        void Start()
        {
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
        }

        public void TakeDamage(int damage)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
        }

      /*  public void OnCollisionEnter2D(Collision2D other)
        {
            var isEnemy = this.gameObject.tag == "Enemy";

            if (isEnemy)
            {
                if (other.gameObject.tag == "Player")
                {
                }
                else
                {
                    if (other.gameObject.tag == "Enemy")
                    {
                        TakeDamage(5);
                    }
                }
            }
        }*/
    }

}
