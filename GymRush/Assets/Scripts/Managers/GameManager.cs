using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject StartP, InGameP, NextP, GameOverP;
    public float CountDown = 2f;

    [SerializeField] private int asynSceneIndex = 1;
    public enum GameState
    {
        Start,
        InGame,
        Next,
        GameOver
    }

    public GameState gamestate;

    public enum Panels
    {
        Startp,
        Nextp,
        GameOverp,
        Ingamep
    }

    private void Start()
    {
        gamestate = GameState.Start;
    }

    private void Update()
    {
        switch (gamestate)
        {
            case GameState.Start: GameStart();
                break;
            case GameState.InGame: GameInGame();
                break;
            case GameState.Next: GameFinisht();
                break;
            case GameState.GameOver: GameOver();
                break;
        }
    }

    void GameStart()
    {
        PanelController(Panels.Startp);
        // TAP TO PLAY
        if (Input.GetMouseButtonDown(0)) gamestate = GameState.InGame;
        if (SceneManager.sceneCount < 2) SceneManager.LoadSceneAsync(asynSceneIndex, LoadSceneMode.Additive);
    }

    void GameInGame()
    {
        PanelController(Panels.Ingamep);
    }

    void GameFinisht()
    {
        PanelController(Panels.Nextp);
    }

    void GameOver()
    {
        CountDown -= Time.deltaTime;
        if (CountDown < 0) PanelController(Panels.GameOverp);
    }

    void PanelController(Panels currentPanel)
    {
        StartP.SetActive(false);
        InGameP.SetActive(false);
        NextP.SetActive(false);
        GameOverP.SetActive(false);

        switch (currentPanel)
        {
            case Panels.Startp: StartP.SetActive(true);
                break;
            case Panels.Ingamep: InGameP.SetActive(true);
                break;
            case Panels.Nextp: NextP.SetActive(true);
                break;
            case Panels.GameOverp: GameOverP.SetActive(true);
                break;
        }
    }

    public void RestartButton()
    {
        SceneManager.UnloadSceneAsync(asynSceneIndex);
        gamestate = GameState.Start;
    }

    public void NextLevelButton()
    {
        if (SceneManager.sceneCountInBuildSettings == asynSceneIndex +1)
        {
            SceneManager.UnloadSceneAsync(asynSceneIndex);
            asynSceneIndex = 1;
            SceneManager.LoadSceneAsync(asynSceneIndex, LoadSceneMode.Additive);
        }

        else
        {
            if (SceneManager.sceneCount > 1)
            {
                SceneManager.UnloadSceneAsync(asynSceneIndex);
                asynSceneIndex++;
            }
            SceneManager.LoadSceneAsync(asynSceneIndex, LoadSceneMode.Additive);
        }
        gamestate = GameState.Start;
    }
}
