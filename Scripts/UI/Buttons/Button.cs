using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject target;
    private IButtons buttons;

    private void Start()
    {
        buttons = target.GetComponent<IButtons>();
    }

    public void OnButton()
    {
        buttons.Active();
    }
}
