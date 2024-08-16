using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TowerManager : MonoBehaviour
{
    public static TowerManager Instance { get; private set; }
    private List<Tower> towers = new List<Tower>();
    private List<Tower2> towers2 = new List<Tower2>();
    public TextMeshProUGUI towerInfoText;
    public TextMeshProUGUI upgradeCostText;
    public TextMeshProUGUI tower2InfoText;
    public TextMeshProUGUI upgradeCostText2;
    private int upgradeCost = 10;
    private int upgradeCost2 = 10;

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
    }

    public void RegisterTower(Tower tower)
    {
        if (!towers.Contains(tower))
        {
            towers.Add(tower);
            UpdateTowerInfoUI();
            UpdateUpgradeCostUI();
        }
    }
    public void RegisterTower2(Tower2 tower2)
    {
        if (!towers2.Contains(tower2))
        {
            towers2.Add(tower2);
            UpdateTower2InfoUI();
            UpdateUpgradeCostUI2();
        }
    }

    public void UpgradeAllTowers()
    {
        if (GameManager.Instance.Money >= upgradeCost)
        {
            GameManager.Instance.SpendMoney(upgradeCost);
            foreach (Tower tower in towers)
            {
                tower.Upgrade();
            }
            upgradeCost += 10;
            UpdateTowerInfoUI();
            UpdateUpgradeCostUI();
        }
        else
        {
            Debug.LogWarning("업그레이드 실패: 돈이 부족합니다.");
        }
    }
    public void UpgradeAllTowers2()
    {
        if (GameManager.Instance.Money >= upgradeCost2)
        {
            GameManager.Instance.SpendMoney(upgradeCost2);
            foreach (Tower2 tower2 in towers2)
            {
                tower2.Upgrade();
            }
            upgradeCost2 += 10;
            UpdateTower2InfoUI();
            UpdateUpgradeCostUI2();
        }
        else
        {
            Debug.LogWarning("업그레이드 실패: 돈이 부족합니다.");
        }
    }

    public void UpdateTowerInfoUI()
    {
        if (towerInfoText != null)
        {
            int totalAttackDamage = 0;
            int totalLevel = 0;

            foreach (Tower tower in towers)
            {
                totalAttackDamage += tower.attackDamage;
                totalLevel += tower.level;
            }
            int averageLevel = towers.Count > 0 ? totalLevel / towers.Count : 0;
            string info = $"Level: {averageLevel}\n";

            towerInfoText.text = info;
        }
    }
    public void UpdateTower2InfoUI()
    {
        if (tower2InfoText != null)
        {
            int totalAttackDamage2 = 0;
            int totalLevel2 = 0;

            foreach (Tower2 tower2 in towers2)
            {
                totalAttackDamage2 += tower2.attackDamage;
                totalLevel2 += tower2.level;
            }
            int averageLevel2 = towers2.Count > 0 ? totalLevel2 / towers2.Count : 0;
            string info = $"Level: {averageLevel2}\n";

            tower2InfoText.text = info;
        }
    }
    public void UpdateUpgradeCostUI()
    {
        if (upgradeCostText != null)
        {

            upgradeCostText.text = $"Cost: {upgradeCost}";
        }
    } 
    public void UpdateUpgradeCostUI2()
    {
        if (upgradeCostText2 != null)
        {

            upgradeCostText2.text = $"Cost: {upgradeCost2}";
        }
    }

}
