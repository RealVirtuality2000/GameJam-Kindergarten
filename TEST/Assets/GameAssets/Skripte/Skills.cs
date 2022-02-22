using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour
{
    //private GameObject Player;

    private static int skillpoints = 0;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        //GameStateManager.Instance.OnGameStateChanged += OnGameStateChanged;
    }

    private void Start()
    {
        //Player = GameObject.Find("Player");
    }

    private void Update()
    {
        if(PlayerStats.experience == 10)
        {
            skillpoints++;
            skill_event();
            level_up();
        }
    }

    private void skill_event()
    {
        GameStateManager.Instance.SetState(GameState.Skill);
        //UI interaktion für auswahl skill
        //on click GameState -> Gameplay
    }

    private void level_up()
    {
        PlayerStats.experience = 0;
        PlayerStats.level++;
    }

    private void inc_max_lifepoints()
    {
        PlayerStats.max_lifepoints += 10f;
    }

    private void inc_life_regeneration()
    {
        PlayerStats.life_regeneration += 1f;
    }

    private void inc_weapon_damage()
    {
        PlayerStats.weapon_damage += 2f;
    }

    private void inc_ability_damage()
    {
        PlayerStats.ability_damage += 5f;
    }

    private void inc_resistence()
    {
        PlayerStats.resistence += 5f;
    }

    private void inc_loot()
    {
        PlayerStats.luck += 5f;
    }
}
