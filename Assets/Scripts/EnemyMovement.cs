using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyMovement: MonoBehaviour
    {
        public float moveSpeed = 0.1f;
        public Rigidbody2D rb;
        public Animator animator;
        protected Vector2 movement;

        protected float update;

        void Update()
        {
            update += Time.deltaTime;
            if (update > 1.0f)
            {
                update = 0.0f;
                movement.x = Random.Range(-1, 2);
                movement.y = Random.Range(-1, 2);

                animator.SetFloat("Horizontal", movement.x);
                animator.SetFloat("Vertical", movement.y);
                animator.SetFloat("Speed", movement.sqrMagnitude);
            }

        }
        private void FixedUpdate()
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }

}

