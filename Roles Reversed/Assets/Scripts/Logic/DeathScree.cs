using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScree : MonoBehaviour
{
    public static GameObject deathScree;

    public static void UDed()
    {
        deathScree.SetActive(true);
    }
}
