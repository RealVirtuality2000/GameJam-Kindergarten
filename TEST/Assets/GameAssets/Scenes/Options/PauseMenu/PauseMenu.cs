using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject pauseMenuUI;
    // Update is called once per frame
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameState currentGameState = GameStateManager.Instance.CurrentGameState;
            if (GamePaused)
            {
                Resume();
                GameState newGameState = currentGameState == GameState.Pause ? GameState.Gameplay : GameState.Pause;
                GameStateManager.Instance.SetState(newGameState);
            }
            else
            {
                Pause();
                GameState newGameState = currentGameState == GameState.Gameplay ? GameState.Pause : GameState.Gameplay;
                GameStateManager.Instance.SetState(newGameState);
            }

            
           

           
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
        GameState currentGameState = GameStateManager.Instance.CurrentGameState;
        GameState newGameState = currentGameState == GameState.Pause ? GameState.Gameplay : GameState.Pause;
        GameStateManager.Instance.SetState(newGameState);
    }

    private void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menü", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting game...");
    }
}
