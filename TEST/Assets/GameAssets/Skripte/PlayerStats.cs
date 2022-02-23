using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
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
    public static int level = 1;

    public HealthbarSkript healthbar;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        lifepoints = max_lifepoints;
        healthbar.SetMaxHealth(lifepoints);
        //weapon_damage = GetComponent<Weapon>.Damage;
        //ability_damage = GetComponent<Ability>.Damage;
    }
}
