using TMPro;
using UnityEngine;

public class PointUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI pointtext;
    private void OnEnable()
    {
        UIManager.Instance.UpdatePointUI(pointtext);
    }
}
