using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public GameObject spawner;
    public EnemySpawner Spawner {  get; private set; }

    public int EnemyCount = 0;

    private void Start()
    {
        Spawner = spawner.GetComponent<EnemySpawner>();
    }

    public void AddEnemyCount(int num)
    {
        EnemyCount += num;
        if (EnemyCount <= 0)
        {
            EnemyCount = 0;
        }
    }
}
