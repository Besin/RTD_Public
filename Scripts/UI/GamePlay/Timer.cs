using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timer;

    private EndTimer endTimer;

    private void Start()
    {
        if (timer == null)
        {
            timer = GetComponentInChildren<TextMeshProUGUI>();
        }
        endTimer = GetComponent<EndTimer>();
    }
    private void Update()
    {
        timer.text = GameManager.Instance.Timer.ToString("N0");

        if (GameManager.Instance.Timer <= 0)
        {
            endTimer.OnEnd();
        }
    }
}
