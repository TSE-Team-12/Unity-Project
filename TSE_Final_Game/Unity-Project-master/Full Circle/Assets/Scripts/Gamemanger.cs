using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public enum GameState
{
    Running,
    Pause
}

public class Gamemanger : MonoBehaviour
{
    public GameState gameState = GameState.Running;
    public static Gamemanger _instance; 
    public int PlayerScore = 0;
    public Text ScoreUI;
    void Awake()
    {
        _instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreUI.text = "Score:" + PlayerScore;
    }

    public void transformGameState()
    {
        if (gameState == GameState.Running)
        {
            GamePause();
        }
        else if (gameState == GameState.Pause)
        {
            ContinueGame();
        }
    }
    public void GamePause()
    {
        Time.timeScale = 0;
        gameState = GameState.Pause;
    }
    public void ContinueGame()
    {
        Time.timeScale = 1;
        gameState = GameState.Running;
    }
}
