using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public static float lifepoints;
    public static float max_lifepoints = 100f;
    public static float life_regeneration = 0.5f;

    public static float weapon_damage;
    public static float ability_damage;

    public static float resistence = 0f; //weniger Fallenschaden
    public static float luck = 0f; //chance mehr candy zu bekommen

    public static int candy = 0; //Item zum Heilen

    public static int experience = 0;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        lifepoints = max_lifepoints;
        //weapon_damage = GetComponent<Weapon>.Damage;
        //ability_damage = GetComponent<Ability>.Damage;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void attack()
    {

    }

    private void use_ability()
    {

    }

    private void use_item()
    {
        candy--;
        lifepoints += 10f;
    }

    public static void level_up()
    {
        experience = 0;
    }
}
