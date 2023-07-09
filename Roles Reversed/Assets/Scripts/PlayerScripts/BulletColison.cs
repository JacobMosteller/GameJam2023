using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class BulletColison : MonoBehaviour
{
    public GameObject explosion;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("EnemyBullet") || collision.gameObject.CompareTag("Enemy"))
        {
            UnArm(collision);
            AutoSpawn.bulletIsDead = true;
        }
    }

    public void UnArm(Collision2D collison)
    {
        if (collison.gameObject.CompareTag("ground"))
        {
            Destroy(this.gameObject);
        }
        else 
        {
            Destroy(collison.gameObject);
            Destroy(this.gameObject);
        }

        Instantiate(explosion, transform.position, transform.rotation);
    }

}
