public class Tal2Up : TalUpgradeBtns, IButtons
{
    public void Active()
    {
        TalentManager.Instance.upgrades.UpgradeTal2();
        UIManager.Instance.UpdatePointUI(pointtxt);
    }
    private void Update()
    {
        text.text = "Ÿ��\n" + "���ݼӵ�\n" + $"{DataManager.Instance.TalentData.tal2}/10";
    }
}
