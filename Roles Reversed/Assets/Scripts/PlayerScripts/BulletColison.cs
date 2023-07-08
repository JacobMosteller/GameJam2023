using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletColison : MonoBehaviour
{
    public Camera main;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "EnemyBullet" || collision.gameObject.tag == "Enemy")
        {
            UnArm(collision);
            GetComponent<Rigidbody2D>().gravityScale = 5;
        }
    }

    public void UnArm(Collision2D collison)
    {
        if (collison.gameObject.tag == "ground")
        {
            Destroy(this.gameObject);
        }
        else 
        {
            Destroy(collison.gameObject);
            Destroy(this.gameObject);
        }
    }
}
