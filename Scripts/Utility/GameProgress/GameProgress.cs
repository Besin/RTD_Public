using UnityEngine;
using UnityEngine.SceneManagement;

public class GameProgress
{
    GameState saveGameState = GameState.Wait;
    public bool IsPause { get; private set; } = false;

    public void OnMain()
    {
        SceneManager.LoadScene(0);
        GameManager.Instance.SetState(GameState.Main);
        if (IsPause)
        {
            IsPause = false;
            Time.timeScale = 1;
        }
    }
    public void OnNewGame()
    {
        SceneManager.LoadScene(1);
        saveGameState = GameState.Wait;
        GameManager.Instance.SetState(GameState.Wait);
        GameManager.Instance.SetRound(1);
        GameManager.Instance.SetMaxRound(50);
        GameManager.Instance.SetLife(20);
        GameManager.Instance.SetMoney(200 + TalentManager.Instance.Tal3AddStartMoney());
        GameManager.Instance.SetTimer(60);
        GameManager.Instance.SetScore(0);
        if (IsPause)
        {
            IsPause = false;
            Time.timeScale = 1;
        }
    }
    public void OnLoadGame()
    {

    }
    public void OnGameStop()
    {
        if (!IsPause)
        {
            saveGameState = GameManager.Instance.State;
        }
        if (IsPause)
        {
            GameManager.Instance.SetState(saveGameState);
            IsPause = false;
            Time.timeScale = 1;
        }
        else
        {
            GameManager.Instance.SetState(GameState.Pause);
            IsPause = true;
            Time.timeScale = 0;
        }
    }
    public void OnGameOver()
    {
        GameManager.Instance.SetState(GameState.Over);
        IsPause = true;
        Time.timeScale = 0;
        UIManager.Instance.OnGameOverUI();
    }
    public void OnGameClaer()
    {
        GameManager.Instance.SetState(GameState.Claer);
        TalentManager.Instance.AddPoints(2);
        DataManager.Instance.Save(DataManager.Instance.TalentData);
        IsPause = true;
        Time.timeScale = 0;
        UIManager.Instance.OnGameClaerUI();
    }
    public void OnNextRound()
    {
        GameManager.Instance.AddScore();
        if (GameManager.Instance.MaxRound > GameManager.Instance.Round)
        {
            GameManager.Instance.IncomMoney();
            GameManager.Instance.AddRound();
            GameManager.Instance.SetState(GameState.Wait);
            saveGameState = GameState.Wait;
            GameManager.Instance.SetTimer(20);
        }
        else if (GameManager.Instance.MaxRound == GameManager.Instance.Round)
        {
            OnGameClaer();
        }
    }
    public void OnStartRound()
    {
        NavMeshManager.Instance.UptateNav();
        GameManager.Instance.SetState(GameState.Play);
        saveGameState = GameState.Play;
        GameManager.Instance.SetTimer(120);

        // TODO : 추후에 공세유형을 정하는 기능을 만들어 교체하기
        // 기능 구현 완료.
        EnemyManager.Instance.Spawner.SpawnEnemyAttack();
    }

    public int OnEnemyType()
    {
        int dataIndex = Random.Range(0, 5);
        return dataIndex;
    }
}
