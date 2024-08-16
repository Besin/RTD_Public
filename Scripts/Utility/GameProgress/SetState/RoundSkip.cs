using UnityEngine;

public class RoundSkip : MonoBehaviour, IProgress
{
    public void Progress()
    {
        if (GameManager.Instance.State == GameState.Wait)
        {
            GameManager.Instance.Progress.OnStartRound();
        }
    }
}
