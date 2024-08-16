using UnityEngine;
using TMPro;

public class UpgradeButton : MonoBehaviour
{
    private TowerManager towerManager;
    public TextMeshProUGUI[] buttonTexts;

    void Start()
    {
        towerManager = TowerManager.Instance;
        UpdateButtonTexts();
    }

    public void OnUpgradeButtonClick(int buttonIndex)
    {
        if (towerManager != null)
        {
            if (buttonIndex == 0)
            {
                towerManager.UpgradeAllTowers();
            }
            else if (buttonIndex == 1)
            {
                towerManager.UpgradeAllTowers2();
            }
        }
    }

    private void UpdateButtonTexts()
    {
        if (buttonTexts.Length > 0)
        {
            buttonTexts[0].text = "Upgrade Tower1";
            buttonTexts[1].text = "Upgrade Tower2";
        }
    }
}
