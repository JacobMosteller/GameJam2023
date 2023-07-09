using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public float loadLevelDelay = .1f;
    public WinScreen win;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(LoadNextLevel());
        }
        else return;
        
    }

    IEnumerator LoadNextLevel()
    {
        yield return new WaitForSecondsRealtime(loadLevelDelay);
        win.LoadScreenScene();
    }
}
