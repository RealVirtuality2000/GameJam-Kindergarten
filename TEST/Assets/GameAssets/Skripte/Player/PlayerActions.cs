using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    private GameObject Player;

    public Transform attack_point;
    public float attack_range = 2f;
    public LayerMask enemy_layer;

    private void Awake()
    {
        GameStateManager.Instance.OnGameStateChanged += OnGameStateChanged;
    }

    private void OnDestroy()
    {
        GameStateManager.Instance.OnGameStateChanged -= OnGameStateChanged;
    }

    // Start is called before the first frame update
    private void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    private void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            attack();
        }
    }

    private void OnGameStateChanged(GameState newGameState)
    {
        enabled = newGameState == GameState.Gameplay;
    }

    private void attack()
    {
        //animation
        //range detection
        Collider[] hit_enemies = Physics.OverlapSphere(attack_point.position, attack_range, enemy_layer);
        //apply damage
        foreach(Collider enemy in hit_enemies)
        {
            Debug.Log("we hit " + enemy.name);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attack_point == null) return;
        Gizmos.DrawWireSphere(attack_point.position, attack_range);
    }

    private void use_ability()
    {
        //animation
        //range detection
        //apply damage
    }

    private void use_item()
    {
        //animation
        PlayerStats.candy--;
        PlayerStats.lifepoints += 10f;
    }

}
