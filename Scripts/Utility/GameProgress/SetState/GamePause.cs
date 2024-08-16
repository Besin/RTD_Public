using UnityEngine;

public class GamePause : MonoBehaviour, IProgress
{
    public void Progress()
    {
        GameManager.Instance.Progress.OnGameStop();
        UIManager.Instance.OnPauseUI();
    }
}
