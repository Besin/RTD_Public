using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshPathSimulation : MonoBehaviour
{
    public bool IsPath { get; private set; } = true;
    public bool showPath;
    public bool showAhead;

    void Start()
    {
        StartCoroutine(PathStatusCorutine());
    }

    private IEnumerator PathStatusCorutine()
    {
        yield return null;
        yield return null;
        SimulationPathStatus();
    }
    public void SimulationPathStatus()
    {
        NavMeshManager.Instance.agent.CalculatePath(NavMeshManager.Instance.target.transform.localPosition, NavMeshManager.Instance.navPath);
        NavMeshManager.Instance.agent.SetPath(NavMeshManager.Instance.navPath);
        if (NavMeshManager.Instance.agent.pathStatus == NavMeshPathStatus.PathComplete)
        {
            IsPath = true;
        }
        else if (NavMeshManager.Instance.agent.pathStatus == NavMeshPathStatus.PathPartial)
        {
            IsPath = false;
        }
    }

}

