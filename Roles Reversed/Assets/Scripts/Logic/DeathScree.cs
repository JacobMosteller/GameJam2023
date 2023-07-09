using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScree : MonoBehaviour
{
    public GameObject deathScree;

    public void UDed()
    {
        deathScree.SetActive(true);
    }

    public void TryAgain()
    {
        int currentScreneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScreneIndex);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
