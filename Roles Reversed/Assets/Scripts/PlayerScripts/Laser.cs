using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    public GameObject explode;


    private void OnTriggerEnter2D(Collider2D other)
    {
        EnemyHealth eH = other.GetComponent<EnemyHealth>();
        if (other.CompareTag("EnemyBullet"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Instantiate(explode, other.transform.position, other.transform.rotation);
        }
        else if(other.CompareTag("Enemy"))
        {
            eH.TakeHit(17);
            Destroy(gameObject);
        }
        else { Destroy(gameObject); }

    }
}
