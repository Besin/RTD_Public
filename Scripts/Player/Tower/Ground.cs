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
            UIManager.Instance.OnSystemMassage("���� ���� �� �����ϴ�.");

            //TODO : ���Ŀ� ������ �ȴٸ� �Ǹ� ������ �����ϸ� ���� �� ����

            GameManager.Instance.AddMoney(10);
            dummy.SetActive(false);
            NavMeshManager.Instance.UptateNav();
            Destroy(gameObject);
        }
    }
}
