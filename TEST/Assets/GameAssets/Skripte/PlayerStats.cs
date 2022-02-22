using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int HP = 100;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
