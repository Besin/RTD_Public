public class Tal1Up : TalUpgradeBtns, IButtons
{
    public void Active()
    {
        TalentManager.Instance.upgrades.UpgradeTal1();
        UIManager.Instance.UpdatePointUI(pointtxt);
    }
    private void Update()
    {
        text.text = "Ÿ��\n" + "���ݷ�\n" + $"{DataManager.Instance.TalentData.tal1}/10";
    }
}
