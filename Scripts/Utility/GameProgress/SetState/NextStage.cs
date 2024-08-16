using UnityEngine;

public class NextStage : MonoBehaviour, IProgress
{
    public void Progress()
    {
        if (GameManager.Instance.State == GameState.Wait)
        {
            GameManager.Instance.Progress.OnStartRound();
        }
        else if (GameManager.Instance.State == GameState.Play)
        {
            GameManager.Instance.Progress.OnNextRound();
        }
    }
}
