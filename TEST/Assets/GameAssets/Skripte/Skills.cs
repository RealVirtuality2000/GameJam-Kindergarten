using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Skills : MonoBehaviour
{
    //private GameObject Player;

    [SerializeField] private Button img1;
    [SerializeField] private Button img2;
    [SerializeField] private Button img3;
    [SerializeField] private Sprite hp_inc, reg_inc, weapon_dmg_inc, inc_res, speed_inc, loot_img, inc_range_img;

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
        //skill_event(); //zum testen
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
        Debug.Log(random_skill_1);
        switch(random_skill_1)
        {
            case 0:
                img1.GetComponent<Image>().sprite = hp_inc;
                break;
            case 1:
                img1.GetComponent<Image>().sprite = reg_inc;
                break;
        }

        random_skill_2 = Random.Range(2, 4);
        switch (random_skill_2)
        {
            case 2:
                img2.GetComponent<Image>().sprite = weapon_dmg_inc;
                break;
            case 3:
                img2.GetComponent<Image>().sprite = inc_res;
                break;
        }
        Debug.Log(random_skill_2);

        random_skill_3 = Random.Range(4, 7);
        switch (random_skill_1)
        {
            case 4:
                img3.GetComponent<Image>().sprite = speed_inc;
                break;
            case 5:
                img3.GetComponent<Image>().sprite = loot_img;
                break;
            case 6:
                img3.GetComponent<Image>().sprite = inc_range_img;
                break;
        }
        Debug.Log(random_skill_3);

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

    public void inc_resistance() // skill 3
    {
        PlayerStats.resistance += 5f;
    }

    public void inc_speed() //Skill 4
    {
        PlayerStats.speed += 1f;
    }

    public void loot() //Skill 5
    {
        PlayerStats.candy += 1;
    }

    public void inc_range() //Skill 6
    {
        PlayerStats.range += 1f;
    }

//public void inc_ability_damage() // skill 5
    //{
    //    PlayerStats.ability_damage += 5f;
    //}

    //public void inc_loot() // skill 6
    //{
    //    PlayerStats.luck += 5f;
    //}
}
