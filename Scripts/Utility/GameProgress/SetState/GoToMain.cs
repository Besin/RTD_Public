using UnityEngine;

public class GoToMain : MonoBehaviour, IProgress
{
    public void Progress()
    {
        GameManager.Instance.Progress.OnMain();
    }
}
