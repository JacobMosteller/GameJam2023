using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimGun : MonoBehaviour
{
    public GameObject crossHair;
    public GameObject player;
    public GameObject bulletPrefab;

    public float bulletSpeed = 60.0f;

    private Vector3 target;

    private void Start()
    {
        //Cursor.visible = false;
    }

    private void Update()
    {
        Aim();
    }

    private void Aim()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crossHair.transform.position = new Vector2(target.x, target.y);

        Vector3 difference = target - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        player.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
    }
}
