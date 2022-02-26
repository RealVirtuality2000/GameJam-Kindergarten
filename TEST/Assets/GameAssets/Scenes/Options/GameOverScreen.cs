using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void Play()
    {
        PlayerStats.lifepoints = 100;
        GameObject.Find("HealthbarPlayer").GetComponent<HealthbarSkript>().SetHealth(PlayerStats.lifepoints);
        PlayerStats.max_lifepoints = 100;
        PlayerStats.life_regeneration = 0.5f;
        PlayerStats.weapon_damage = 10;
        PlayerStats.resistance = 0f;
        PlayerStats.range = 0f;
        PlayerStats.candy = 0;
        PlayerStats.experience = 0;
        PlayerStats.level = 1;

        SceneManager.LoadScene("Kindergarden", LoadSceneMode.Single);
    }


    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();

    }
}
