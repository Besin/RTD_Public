using UnityEngine;

public class NavMeshUpdate : MonoBehaviour
{
    void Start()
    {
        NavMeshManager.Instance.UptateNav();
    }

    private void OnApplicationQuit()
    {
        NavMeshManager.Instance.UptateNav();
    }
    private void OnDestroy()
    {
        NavMeshManager.Instance.UptateNav();
    }
}
