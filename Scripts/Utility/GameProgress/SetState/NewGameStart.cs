using UnityEngine;

public class NewGameStart : MonoBehaviour, IProgress
{
    public void Progress()
    {
        GameManager.Instance.Progress.OnNewGame();
    }
}
