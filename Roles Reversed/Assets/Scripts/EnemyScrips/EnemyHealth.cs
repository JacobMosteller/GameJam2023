using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public static float health = 100;

    public static void TakeHit(float damage)
    {
        health -= damage;
    }
    public void Die()
    {
        if (health <= 0f)
        {
            Destroy(gameObject);
        }

    }
}
