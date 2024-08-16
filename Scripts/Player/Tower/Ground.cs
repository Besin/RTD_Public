using System.Collections;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject main;
    public GameObject dummy;

    private void Awake()
    {
        main.SetActive(false);
        dummy.SetActive(true);
    }
    private void Start()
    {
        StartCoroutine(CheckingBuildGround());
    }
    public IEnumerator CheckingBuildGround()
    {
        NavMeshManager.Instance.Path.SimulationPathStatus();
        yield return null;
        yield return null;

        NavMeshManager.Instance.Path.SimulationPathStatus();
        if (NavMeshManager.Instance.Path.IsPath)
        {
            main.SetActive(true);
            dummy.SetActive(false);
            NavMeshManager.Instance.UptateNav();
        }
        else if (!NavMeshManager.Instance.Path.IsPath)
        {
            UIManager.Instance.OnSystemMassage("길을 막을 수 없습니다.");

            //TODO : 추후에 여유가 된다면 판매 로직을 개선하면 좋을 것 같음

            GameManager.Instance.AddMoney(10);
            dummy.SetActive(false);
            NavMeshManager.Instance.UptateNav();
            Destroy(gameObject);
        }
    }
}
