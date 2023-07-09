using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public GameObject winScreen;
  
    public void PlayAgain()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        AutoSpawn.bulletIsDead = true;

    }
   

    public void LoadScreenScene()
    {
        winScreen.SetActive(true);
    }
    


}
