using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAutoMove : MonoBehaviour
{
    private Rigidbody2D autoRunRb;
    public float runSpeed = 5f;

    private void Awake()
    {
        autoRunRb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        AutoRun();
    }

    public void AutoRun()
    {
        Vector2 direction = new Vector2(-1, 0);
        Vector2 velocity = direction.normalized * runSpeed;

        autoRunRb.velocity = velocity;
    }
}
