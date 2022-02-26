using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerActions : MonoBehaviour
{
    private GameObject Player;

    public Transform attack_point;
    public float attack_range = PlayerStats.range;
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

        if (Input.GetKeyDown(KeyCode.Q))
        {
            ChangeScene();
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
       

        foreach (Collider enemy in hit_enemies)
        {
            Debug.Log("we hit " + enemy.name);
            if(enemy.name == "Monkey")
            {
                FindObjectOfType<AudioManager>().Play("PlayerAttack");
                enemy.GetComponent<MonkeyHealth>().TakeDamage(PlayerStats.weapon_damage);
            }else if(enemy.name == "Teacher")
            {
                FindObjectOfType<AudioManager>().Play("PlayerAttack");
                enemy.GetComponent<BossHealth>().TakeDamage(PlayerStats.weapon_damage);
            }else if(enemy.name == "Brokkoli")
            {
                FindObjectOfType<AudioManager>().Play("PlayerAttack");
                enemy.GetComponent<BrokkoliHealth>().TakeDamage(PlayerStats.weapon_damage);
            }

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

    private void ChangeScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "Kindergarden")
        {
            SceneManager.LoadScene("ImaginaryWorld", LoadSceneMode.Single);
        }
        else if (sceneName == "ImaginaryWorld")
        {
            SceneManager.LoadScene("Kindergarden", LoadSceneMode.Single);
        }
    }

}
