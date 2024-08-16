using UnityEngine;

public class HowToPlayBtn : MonoBehaviour, IButtons
{
    public void Active()
    {
        UIManager.Instance.OnHowToPlayUI();
    }
}
