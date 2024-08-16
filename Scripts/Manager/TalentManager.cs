using UnityEngine;

public class TalentManager : MonoBehaviour
{
    public static TalentManager Instance { get; private set; }
    public TalentUpgrades upgrades {  get; private set; }
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
        upgrades = new TalentUpgrades();
    }


    public void AddPoints(int num)
    {
        DataManager.Instance.TalentData.point += num;
    }

    public float Tal1TowerAttackSpeed(float asd)
    {
        float upgrade = asd * DataManager.Instance.TalentData.tal1 * 0.01f;
        return upgrade;
    }
    public int Tal2TowerAttackPower(int atk)
    {
        return (int)(atk * DataManager.Instance.TalentData.tal2 * 0.02f);
    }
    public int Tal3AddStartMoney()
    {
        if (DataManager.Instance.TalentData != null)
        {
            return DataManager.Instance.TalentData.tal3 * 20;
        }
        return 0;
    }
}
