using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Candy : MonoBehaviour
{
    private float healing = 30;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            heal_candy(healing);
        }
    }
    
    private void heal_candy(float heal)
    {

        if (PlayerStats.candy > 0) 
            {

                if (PlayerStats.lifepoints <= PlayerStats.max_lifepoints - heal)
                {
         
                    PlayerStats.lifepoints += heal;
                    GameObject.Find("HealthbarPlayer").GetComponent<HealthbarSkript>().SetHealth(PlayerStats.lifepoints);
                    Debug.Log("Legga Candy");  

                }
                else
                {
                    PlayerStats.lifepoints = PlayerStats.max_lifepoints;
                    GameObject.Find("HealthbarPlayer").GetComponent<HealthbarSkript>().SetHealth(PlayerStats.lifepoints);
                    Debug.Log("Ich bin satt!");
                }

            }
            else { return; }
        
    }

}
