using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string zielszene;

    public void Wechsel()
    {
        Debug.Log("Lade Szene");
        SceneManager.LoadScene(zielszene, LoadSceneMode.Single);
    }

}
