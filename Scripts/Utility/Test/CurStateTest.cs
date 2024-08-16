using TMPro;
using UnityEngine;

public class CurStateTest : MonoBehaviour
{
    private TextMeshProUGUI test;

    private void Start()
    {
        test = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        test.text = GameManager.Instance.State.ToString();
    }
}
