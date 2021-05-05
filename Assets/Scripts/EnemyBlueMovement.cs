using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlueMovement : MonoBehaviour
{
    public float timer;
    public int newTarget = 100;
    public float speed;
    public Rigidbody2D rb;
    public Vector2 target;

    public void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        timer += Time.deltaTime;

        if(timer >= newTarget)
        {
            NewTarget();
            timer = 0;
        }

    }

    void NewTarget()
    {
        float myX = gameObject.transform.position.x;
        float myY = gameObject.transform.position.y;

        float xPos = Random.Range(myX - 1, myX + 1);

        target = new Vector2(xPos, myY);
        rb.MovePosition(target);
    }
}
