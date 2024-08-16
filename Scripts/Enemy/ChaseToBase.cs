using UnityEngine;
using UnityEngine.AI;

public class ChaseToBase : MonoBehaviour
{
    private NavMeshAgent agent;
    private Enemy data;
    private NavMeshPath path;

    public Transform targetPosition;
    public bool showPath;
    public bool showAhead;

    private void Awake()
    {
        path = new NavMeshPath();
        data = GetComponent<Enemy>();
        agent = GetComponent<NavMeshAgent>();
    }
    private void Start()
    {
        targetPosition = GameManager.Instance.baseTransform;
    }
    void Update()
    {
        if (data.EnemyData.isFly)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition.position, Time.deltaTime * data.EnemyData.speed);
        }
        else
        {
            SearchPath();
        }
        if ((transform.position - NavMeshManager.Instance.target.transform.position).magnitude <= 0.2f)
        {
            OnEnterBase();
        }
    }

    private void OnDrawGizmos()
    {
        Navigate.DrawGizmos(agent, showPath, showAhead);
    }

    public void IsFlyCheck()
    {
        if (data.EnemyData.isFly)
        {
            agent.enabled = false;
        }
        else
        {
            agent.enabled = true;
        }
    }
    private void SearchPath()
    {
        agent.speed = data.EnemyData.speed;
        agent.avoidancePriority = 100 - (int)data.EnemyData.speed;
        agent.CalculatePath(NavMeshManager.Instance.target.transform.position, path);
        agent.SetPath(path);
    }
    private void OnEnterBase()
    {
        GameManager.Instance.AddLife(-1);
        EnemyManager.Instance.AddEnemyCount(-1);
        gameObject.SetActive(false);
        if (GameManager.Instance.Life <= 0)
        {
            GameManager.Instance.Progress.OnGameOver();
        }
        if (EnemyManager.Instance.EnemyCount <= 0)
        {
            EnemyManager.Instance.EnemyCount = 0;
            GameManager.Instance.Progress.OnNextRound();
        }
    }
}
