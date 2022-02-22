using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public float lifepoints;
    public float max_lifepoints = 100f;
    public float life_regeneration = 0.2f;

    public float weapon_damage;
    public float ability_damage;

    public float toughness = 0f;
    public float resistence = 0f;

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
        Debug.Log(lifepoints);
    }

    private void attack()
    {

    }

    private void use_ability()
    {

    }

    private void use_item()
    {

    }
}
