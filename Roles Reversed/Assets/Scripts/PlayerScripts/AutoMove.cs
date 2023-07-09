using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class AutoMove : MonoBehaviour
{

    private Rigidbody2D autoRunRb;
    public float runSpeed = 5f;
    public CinemachineVirtualCamera wickCam;
    public CinemachineVirtualCamera bulletCam;

    private void OnEnable()
    {
        CameraSwitcher.Register(wickCam);
        CameraSwitcher.Register(bulletCam);
    }

    private void OnDisable()
    {
        CameraSwitcher.UnRegister(wickCam);
        CameraSwitcher.UnRegister(bulletCam);
    }



    private void Awake()
    {
        autoRunRb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        AutoRun();
    }

    public void AutoRun()
    {
        Vector2 direction = new Vector2(1, 0);
        Vector2 velocity = direction.normalized * runSpeed;

        autoRunRb.velocity = velocity;
    }
}
