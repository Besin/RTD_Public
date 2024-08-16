public class Tal1Up : TalUpgradeBtns, IButtons
{
    public void Active()
    {
        TalentManager.Instance.upgrades.UpgradeTal1();
        UIManager.Instance.UpdatePointUI(pointtxt);
    }
    private void Update()
    {
        text.text = "타워\n" + "공격력\n" + $"{DataManager.Instance.TalentData.tal1}/10";
    }
}
