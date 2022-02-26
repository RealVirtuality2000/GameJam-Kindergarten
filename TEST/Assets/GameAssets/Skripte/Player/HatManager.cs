using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HatManager : MonoBehaviour
{
    public GameObject hutRL;
    public GameObject hutImag;

    
    private void Update()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "Kindergarden")
        {
            hutImag.SetActive(false);
            hutRL.SetActive(true);
        }
        else if (sceneName == "ImaginaryWorld")
        {
            hutRL.SetActive(false);
            hutImag.SetActive(true);
        }
    }

  
}
