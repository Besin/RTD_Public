public class TalentUpgrades
{
    public void UpgradeTal1()
    {
        if (DataManager.Instance.TalentData.tal1 < 10)
        {
            if (DataManager.Instance.TalentData.point > 0)
            {
                TalentManager.Instance.AddPoints(-1);
                DataManager.Instance.TalentData.tal1 += 1;
                DataManager.Instance.Save(DataManager.Instance.TalentData);
            }
            else
            {
                UIManager.Instance.OnSystemMassage("포인트가 부족합니다.");
            }
        }
        else
        {
            UIManager.Instance.OnSystemMassage("이미 모두 업그레이드 된 항목입니다.");
        }
    }
    public void UpgradeTal2()
    {
        if (DataManager.Instance.TalentData.tal2 < 10)
        {
            if (DataManager.Instance.TalentData.point > 0)
            {
                TalentManager.Instance.AddPoints(-1);
                DataManager.Instance.TalentData.tal2 += 1;
                DataManager.Instance.Save(DataManager.Instance.TalentData);
            }
            else
            {
                UIManager.Instance.OnSystemMassage("포인트가 부족합니다.");
            }
        }
        else
        {
            UIManager.Instance.OnSystemMassage("이미 모두 업그레이드 된 항목입니다.");
        }
    }
    public void UpgradeTal3()
    {
        if (DataManager.Instance.TalentData.tal3 < 10)
        {
            if (DataManager.Instance.TalentData.point > 0)
            {
                TalentManager.Instance.AddPoints(-1);
                DataManager.Instance.TalentData.tal3 += 1;
                DataManager.Instance.Save(DataManager.Instance.TalentData);
            }
            else
            {
                UIManager.Instance.OnSystemMassage("포인트가 부족합니다.");
            }
        }
        else
        {
            UIManager.Instance.OnSystemMassage("이미 모두 업그레이드 된 항목입니다.");
        }
    }
}
