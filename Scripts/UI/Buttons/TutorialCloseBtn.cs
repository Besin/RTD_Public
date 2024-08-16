using UnityEngine;

public class TutorialCloseBtn : MonoBehaviour
{
    public GameObject tutorial;

    public void OnTutorialClose()
    {
        if (tutorial != null)
        {
            Destroy(tutorial);
        }
        TutorialManager.Instance.CloseTutorial();

        Destroy(gameObject);
    }
}
