using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    public GameObject levelPassedScreen;
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        
        Time.timeScale = 1;
        
    }
}
