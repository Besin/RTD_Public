using UnityEngine;

public class EndTimer : GetProgress
{
    public void OnEnd()
    {
        progress.Progress();
    }
}
