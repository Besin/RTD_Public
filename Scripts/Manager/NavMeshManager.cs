using NavMeshPlus.Components;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshManager : MonoBehaviour
{
    public static NavMeshManager Instance { get; private set; }

    public NavMeshPathSimulation Path;

    public GameObject target;
    public NavMeshAgent agent;

    public NavMeshPath navPath;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            if (Instance != this)
            {
                Destroy(gameObject);
            }
        }

        navPath = new NavMeshPath();
    }

    public NavMeshSurface Surface2D;

    private void Start()
    {
        Surface2D = GetComponent<NavMeshSurface>();
        UptateNav();
    }
    public void UptateNav()
    {
        if (Surface2D != null)
        {
            Surface2D.UpdateNavMesh(Surface2D.navMeshData);
        }
    }
}
