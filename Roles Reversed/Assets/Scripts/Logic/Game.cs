using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public int ammo;
    public TextMeshProUGUI lives;
    public TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        lives.text = ammo.ToString();
    }
    private void Update()
    {

        ammo = GetComponent<AimGun>().ammo;
    }

}
