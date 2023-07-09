using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScree : MonoBehaviour
{
    public GameObject deathScree;

    public void UDed()
    {
        deathScree.SetActive(true);
    }

}
