using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Candy : MonoBehaviour
{
    private float healing = 30;

    private void Update()
    {
      if(Input.GetKeyDown(KeyCode.E))
      {
            if(PlayerStats.candy > 0)
            {
                if(PlayerStats.lifepoints <= PlayerStats.max_lifepoints - healing)
                {
                    PlayerStats.lifepoints += healing;
                }
                else { PlayerStats.lifepoints = PlayerStats.max_lifepoints; }
                
            }
            else { return; }
      }  
    }
    

}
