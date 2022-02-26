using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static float lifepoints;
    public static float max_lifepoints = 100f;
    public static float life_regeneration = 5;

    public static float weapon_damage = 10;
    public static float speed = 6f;

    public static float resistance = 0f; //weniger Fallenschaden
    public static float range = 1f; 

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
        InvokeRepeating("Reg", 0.1f, 5);
        //weapon_damage = GetComponent<Weapon>.Damage;
        //ability_damage = GetComponent<Ability>.Damage;
    }

    

    private void Reg()
    {
        
        if(lifepoints < max_lifepoints)
        {
            lifepoints += life_regeneration;
            Debug.Log("Heilen" + lifepoints);
        }
        
    }
    
}
