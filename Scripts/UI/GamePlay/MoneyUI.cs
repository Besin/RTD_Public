using TMPro;
using UnityEngine;

public class MoneyUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    void Update()
    {
        text.text = GameManager.Instance.Money + " $";
    }
}
