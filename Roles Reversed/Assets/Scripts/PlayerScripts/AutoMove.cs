using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{

    private Rigidbody2D autoRunRb;
    public float runSpeed = 5f;

    private void Awake()
    {
        autoRunRb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        AutoRun();
    }

    public void AutoRun()
    {
        autoRunRb.AddForce(Vector2.right * runSpeed * Time.deltaTime, ForceMode2D.Force);
    }
}
