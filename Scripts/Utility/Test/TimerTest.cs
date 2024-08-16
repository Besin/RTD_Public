using TMPro;
using UnityEngine;

public class TimerTest : MonoBehaviour
{
    private TextMeshProUGUI test;
    float time = 0;

    private void Start()
    {
        test = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        time += Time.deltaTime;
        test.text = time.ToString("N2");
    }
}
