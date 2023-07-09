using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public int ammo;
    // Start is called before the first frame update
    void Start()
    {
        ammo = GetComponent<AimGun>().ammo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
