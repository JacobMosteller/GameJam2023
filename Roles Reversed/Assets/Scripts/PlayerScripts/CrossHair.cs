using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossHair : MonoBehaviour
{
    public Camera main;

    // Update is called once per frame
    private void Start()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        AimCrosshair();
    }

    public void AimCrosshair()
    {
        Vector3 target = main.GetComponent<CameraPositon>().TargetCrossHair();
        this.transform.position = new Vector2(target.x, target.y);
    }
}
