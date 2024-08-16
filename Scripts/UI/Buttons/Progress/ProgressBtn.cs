using UnityEngine;

public class ProgressBtn : GetProgress, IButtons
{
    public void Active()
    {
        progress.Progress();
    }
}
