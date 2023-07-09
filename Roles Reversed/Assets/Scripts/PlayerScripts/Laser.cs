using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    public ParticleSystem explode;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        EnemyHealth eH = other.GetComponent<EnemyHealth>();
        if (other.CompareTag("EnemyBullet"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        else if(other.CompareTag("Enemy"))
        {
            eH.TakeHit(34);
            Destroy(gameObject);
        }
        else { Destroy(this.gameObject); }

    }
}
