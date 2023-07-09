using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSpawn : MonoBehaviour
{
    public GameObject gun;
    public GameObject bulletPrefab;
    public GameObject barrel;
    public float bulletSpeed = 0f;
    private Camera main;
    private int ammo;
    private Vector3 target;
    public static bool bulletIsDead = true;

    // Start is called before the first frame update
    void Start()
    {
        ammo = GetComponentInParent<AimGun>().ammo;
        if (Camera.main != null)
        {
            main = Camera.main;
            main.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        BulletSpawn();
    }
    public void BulletSpawn()
    {
        target = main.GetComponent<CameraPositon>().TargetCrossHair();

        Vector3 difference = target - gun.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        if (bulletIsDead)
        {
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            spawnShot(direction, rotationZ);
            ammo--;
            bulletIsDead = false;
        }
    }
    private void spawnShot(Vector2 direction, float rotationZ)
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = barrel.transform.position;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    }
}
