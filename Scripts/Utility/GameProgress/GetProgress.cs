using UnityEngine;

public class GetProgress : MonoBehaviour
{
    [SerializeField]protected GameObject target;
    protected IProgress progress;

    protected virtual void Start()
    {
        progress = target.GetComponent<IProgress>();
    }
}
