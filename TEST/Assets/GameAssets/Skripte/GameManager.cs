using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static bool GameIsRunning;
    public GameObject Player;

    // Start is called before the first frame update
    private void Awake()
    {
        if (!GameIsRunning)
        {
            Instantiate(Player, null);
            GameIsRunning = true;
        }


        DontDestroyOnLoad(this);
        for (int i = 0; i < 10; i++)
        {
            DoorVariables.DoorsOpen[i] = false;
        }
    }


}
