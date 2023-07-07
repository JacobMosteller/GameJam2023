using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletMovement : MonoBehaviour
{
    Rigidbody2D bulletRigidbody;
    public float rotate;
    public float bulletSpeed;
    private bool hasTouched = false;

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
        bulletRigidbody.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotate * Time.deltaTime);
        bulletRigidbody.freezeRotation = false;
    }
    void ApplyRotationRight()
    {
        bulletRigidbody.freezeRotation = true;
        transform.Rotate(Vector3.forward * -rotate * Time.deltaTime);
        bulletRigidbody.freezeRotation = false;
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
        if(!hasTouched)
        bulletRigidbody.AddRelativeForce(Vector2.right * bulletSpeed);
    }

    private Vector2 GetPointerInput()
    {
        Vector3 mousePos = pointerPosition.action.ReadValue<Vector2>();
        mousePos.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}
