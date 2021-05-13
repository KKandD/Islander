using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class EnemyBlueMovement : EnemyMovement
{
    void Update()
    {
        update += Time.deltaTime;
        if (update > 1.0f)
        {
            update = 0.0f;
            movement.x = Random.Range(-1, 2);

            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Speed", movement.sqrMagnitude);
        }
    }
}
