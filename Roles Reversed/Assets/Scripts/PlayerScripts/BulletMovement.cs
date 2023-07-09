using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletMovement : MonoBehaviour
{
    Rigidbody2D bulletRigidbody;
    public float rotate;
    public float bulletSpeed;

    [SerializeField]
    private InputActionReference pointerPosition;
    private void Awake()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        ProcessRotationRight();
        ProcessRotationLeft();
        //pointerPosition = GetPointerInput();
    }

    private void FixedUpdate()
    {
        Fly();
    }

    public void Rotate()
    {

    }
    void ApplyRotationLeft()
    {
        transform.Rotate(0, 0, rotate);
    }
    void ApplyRotationRight()
    {
        transform.Rotate(0, 0, -rotate);
    }
    void ProcessRotationLeft()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ApplyRotationLeft();
        }

    }

    private void ProcessRotationRight()
    {
        if (Input.GetKey(KeyCode.D))
        {
            ApplyRotationRight();
        }
    }

    private void Fly()
    {
        transform.Translate(0.01f * bulletSpeed, 0, 0);
    }
}
