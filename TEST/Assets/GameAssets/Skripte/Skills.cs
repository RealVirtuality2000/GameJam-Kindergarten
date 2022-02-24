using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour
{
    //private GameObject Player;

    private static int skillpoints = 0;
    public int random_skill_1;
    public int random_skill_2;
    public int random_skill_3;

    public GameObject skill_ui;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        //GameStateManager.Instance.OnGameStateChanged += OnGameStateChanged;
    }

    private void Start()
    {
        //Player = GameObject.Find("Player");
        skill_event(); //zum testen
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

        random_skill_1 = Random.Range(0, 2);
        random_skill_2 = Random.Range(2, 4);
        random_skill_3 = Random.Range(4, 6);

        skill_ui.SetActive(true);
    }

    private void level_up()
    {
        PlayerStats.experience = 0;
        PlayerStats.level++;
    }

    public void inc_max_lifepoints() // skill 0
    {
        PlayerStats.max_lifepoints += 10f;
    }

    public void inc_life_regeneration() // skill 1
    {
        PlayerStats.life_regeneration += 1f;
    }

    public void inc_weapon_damage() // skill 2
    {
        PlayerStats.weapon_damage += 2f;
    }

    public void inc_ability_damage() // skill 3
    {
        PlayerStats.ability_damage += 5f;
    }

    public void inc_resistence() // skill 4
    {
        PlayerStats.resistence += 5f;
    }

    public void inc_loot() // skill 5
    {
        PlayerStats.luck += 5f;
    }
}
