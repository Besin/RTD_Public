using TMPro;
using UnityEngine;

public class TalUpgradeBtns : MonoBehaviour
{
    protected TextMeshProUGUI text;
    public TextMeshProUGUI pointtxt;

    private void Awake()
    {
        text = gameObject.GetComponentInChildren<TextMeshProUGUI>();
    }
}
