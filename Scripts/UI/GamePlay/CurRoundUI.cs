using TMPro;
using UnityEngine;

public class CurRoundUI : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI round;

    private void Start()
    {
        if (round == null)
        {
            round = GetComponentInChildren<TextMeshProUGUI>();
        }
    }
    private void Update()
    {
        round.text = "Round " + GameManager.Instance.Round.ToString();
    }
}
