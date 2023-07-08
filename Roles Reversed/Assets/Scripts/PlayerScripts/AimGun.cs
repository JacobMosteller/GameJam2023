using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimGun : MonoBehaviour
{
    public GameObject gun;
    public GameObject bulletPrefab;
    public GameObject barrel;
    private Camera main;
    public int ammo;

    public int mouseNum = 0;


    public float bulletSpeed = 60.0f;

    private Vector3 target;

    private void Start()
    {
        if(Camera.main != null)
        {
            main = Camera.main;
            main.enabled = true;
        }
    }

    private void Update()
    {
        Aim();
    }

    private void Aim()
    {
        target = main.GetComponent<CameraPositon>().TargetCrossHair();

        Vector3 difference = target - gun.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        gun.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

        if (Input.GetMouseButtonDown(mouseNum) && ammo > 0)
        {
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            spawnShot(direction, rotationZ);
            ammo--;
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
