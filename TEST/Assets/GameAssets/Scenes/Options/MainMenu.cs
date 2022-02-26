using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string zielszene;
    public void Play()
    {
        SceneManager.LoadScene(zielszene, LoadSceneMode.Single);
        
    }
    
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
            
    }
}
