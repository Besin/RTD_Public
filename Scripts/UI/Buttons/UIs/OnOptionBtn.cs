using UnityEngine;

public class OnOptionBtn : MonoBehaviour, IButtons
{
    public void Active()
    {
        UIManager.Instance.OnOptionUI();
    }
}
