using UnityEngine;

public class TalentBtn : MonoBehaviour, IButtons
{
    public void Active()
    {
        UIManager.Instance.OnTalentUI();
    }
}
