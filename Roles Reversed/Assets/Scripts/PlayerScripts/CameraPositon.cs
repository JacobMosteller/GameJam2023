using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositon : MonoBehaviour
{

    private Vector3 target;

    public Vector3 TargetCrossHair()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        return target;
    }

}
