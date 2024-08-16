using UnityEngine;

public class GameClaer : MonoBehaviour, IProgress
{
    public void Progress()
    {
        GameManager.Instance.Progress.OnGameClaer();
    }
}
