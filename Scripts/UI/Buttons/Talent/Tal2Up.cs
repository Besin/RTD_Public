public class Tal2Up : TalUpgradeBtns, IButtons
{
    public void Active()
    {
        TalentManager.Instance.upgrades.UpgradeTal2();
        UIManager.Instance.UpdatePointUI(pointtxt);
    }
    private void Update()
    {
        text.text = "타워\n" + "공격속도\n" + $"{DataManager.Instance.TalentData.tal2}/10";
    }
}
