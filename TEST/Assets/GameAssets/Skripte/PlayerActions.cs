using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    private GameObject Player;

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
       
    }

    private void OnGameStateChanged(GameState newGameState)
    {
        enabled = newGameState == GameState.Gameplay;
    }

    private void attack()
    {
        //animation
        //range detection
        //apply damage
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
