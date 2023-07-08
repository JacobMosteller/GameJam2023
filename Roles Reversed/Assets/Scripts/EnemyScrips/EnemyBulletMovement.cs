using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{
    public GameObject enemyBarrel;
    public Rigidbody2D rb;
    public float speed;

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
       
        rb.AddForce(Vector2.left * speed);
        
    }
}
