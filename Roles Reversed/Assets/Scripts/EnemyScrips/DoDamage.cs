using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoDamage : MonoBehaviour
{
    public float damage = 100;
    public GameObject explosion;
    void OnTriggerEnter2D(Collider2D other)
    {
        AutoMove aM = other.GetComponent<AutoMove>();

        if (other.gameObject.CompareTag("Player"))
        {
            aM.TakeAHit(damage);
            Destroy(this.gameObject);
        }
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
