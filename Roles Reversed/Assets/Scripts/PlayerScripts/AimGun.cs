using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimGun : MonoBehaviour
{
    public GameObject crossHair;
    public GameObject player;
    private Vector3 target;

    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crossHair.transform.position = new Vector2(target.x, target.y);
    }
}
