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
                UIManager.Instance.OnSystemMassage("����Ʈ�� �����մϴ�.");
            }
        }
        else
        {
            UIManager.Instance.OnSystemMassage("�̹� ��� ���׷��̵� �� �׸��Դϴ�.");
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
                UIManager.Instance.OnSystemMassage("����Ʈ�� �����մϴ�.");
            }
        }
        else
        {
            UIManager.Instance.OnSystemMassage("�̹� ��� ���׷��̵� �� �׸��Դϴ�.");
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
                UIManager.Instance.OnSystemMassage("����Ʈ�� �����մϴ�.");
            }
        }
        else
        {
            UIManager.Instance.OnSystemMassage("�̹� ��� ���׷��̵� �� �׸��Դϴ�.");
        }
    }
}
