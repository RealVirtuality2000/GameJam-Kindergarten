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
        if(PlayerActions.experience == 10)
        {
            skillpoints++;
            skill_event();
            PlayerActions.level_up();
        }
    }

    private void skill_event()
    {
        GameState newGameState = GameState.Skill;
        //UI interaktion für auswahl skill
        //on click GameState -> Gameplay
    }

    private void inc_max_lifepoints()
    {
        PlayerActions.max_lifepoints += 10f;
    }

    private void inc_life_regeneration()
    {
        PlayerActions.life_regeneration += 1f;
    }

    private void inc_weapon_damage()
    {
        PlayerActions.weapon_damage += 2f;
    }

    private void inc_ability_damage()
    {
        PlayerActions.ability_damage += 5f;
    }

    private void inc_resistence()
    {
        PlayerActions.resistence += 5f;
    }

    private void inc_loot()
    {
        PlayerActions.luck += 5f;
    }
}
