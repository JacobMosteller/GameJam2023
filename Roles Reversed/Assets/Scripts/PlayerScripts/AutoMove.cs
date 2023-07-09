using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class AutoMove : MonoBehaviour
{
    public float health = 100f;
    public GameObject explosion;
    private Rigidbody2D autoRunRb;
    public float runSpeed = 5f;
    public DeathScree uded;

    private void Awake()
    {
        autoRunRb = GetComponent<Rigidbody2D>();

    }
    void FixedUpdate()
    {
        AutoRun();
        
    }
    private void Update()
    {
        Die();
    }

    public void AutoRun()
    {
        Vector2 direction = new Vector2(1, 0);
        Vector2 velocity = direction.normalized * runSpeed;

        autoRunRb.velocity = velocity;
    }
    public void TakeAHit(float damage)
    {
        health -= damage;
        if(health <= 0f)
        {
            uded.UDed();
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    public void Die()
    {
        
        
    }

}
