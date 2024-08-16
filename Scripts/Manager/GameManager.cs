using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (Instance != this)
            {
                Destroy(gameObject);
            }
        }
    }

    private void Update()
    {
        if (State == GameState.Wait || State == GameState.Play && Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
        else if (Timer < 0)
        {
            Timer = 0;
        }
    }

    public Transform baseTransform;

    public GameProgress Progress { get; private set; }
    public GameState State { get; private set; }
    public Difficulty Difficulty { get; private set; }
    public float Timer { get; private set; }
    public int Round { get; private set; }
    public int MaxRound { get; private set; }
    public int Life { get; private set; }
    public int Money { get; private set; }
    public int Score { get; private set; }

    private void Start()
    {
        Progress = new GameProgress();
        State = GameState.Main;
    }


    #region ===== 변수 설정 =====
    public void SetState(GameState state)
    {
        State = state;
    }
    public void SetScore(int num)
    {
        Score = num;
    }
    public void AddScore()
    {
        // TODO : 추후에 난이도 등이 추가되었을 때 자세한 내용 수정
        Score += 100 + (100 + (int)Timer);
    }
    public void SetDifficulty()
    {
        
    }
    public void SetTimer(int num)
    {
        Timer = num;
    }
    public void SetMoney(int num)
    {
        Money = num;
    }
    public void SetRound(int num)
    {
        Round = num;
    }
    public void SetLife(int num)
    {
        Life = num;
    }
    public void SetMaxRound(int num)
    {
        MaxRound = num;
    }
    public void AddMoney(int num)
    {
        Money += num;  
        
    }
    public void SpendMoney(int num)
    {
        Money -= num;
    }
    public void AddLife(int num)
    {
        Life += num;
    }
    public void IncomMoney()
    {
        double setIncom = Money / 100;
        int incom = (int)Math.Round(setIncom);
        
        Money += incom;
    }
    public void AddRound()
    {
        Round++;
    }
   
    public bool available(int num)
    {
        return Money >= num;
    }
     #endregion
}
