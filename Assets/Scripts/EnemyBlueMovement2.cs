using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlueMovement2 : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    void Update()
    {

        movement.x = Random.Range(-1, 2);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Speed", movement.sqrMagnitude);

    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
