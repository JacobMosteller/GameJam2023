using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 100;
    public GameObject exolode;

    public void TakeHit(float damage)
    {
        health -= damage;
        if (health <= 0f)
        {
            Destroy(gameObject);
            Instantiate(exolode, transform.position, transform.rotation);
        }
    }
}
