public class Tal3Up : TalUpgradeBtns, IButtons
{
    public void Active()
    {
        TalentManager.Instance.upgrades.UpgradeTal3();
        UIManager.Instance.UpdatePointUI(pointtxt);
    }
    private void Update()
    {
        text.text = "�ʱ��ڱ�\n" + "����\n" + $"{DataManager.Instance.TalentData.tal3}/10";
    }
}