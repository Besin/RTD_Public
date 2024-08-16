using UnityEngine;

public class CloseBtn : MonoBehaviour, IButtons
{
    public void Active()
    {
        Destroy(gameObject);
    }
}
