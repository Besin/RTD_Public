using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour, IButtons
{
    public GameObject panel;
    public GameObject overlay;
    private CanvasGroup canvasGroup;
    private CanvasGroup overlayCanvasGroup;
    private bool isPanelVisible = false;

    private void Start()
    {
        panel.SetActive(false);
        overlay.SetActive(false);
        canvasGroup = panel.GetComponent<CanvasGroup>();
        overlayCanvasGroup = overlay.GetComponent<CanvasGroup>();
    }

    public void Active()
    {
        isPanelVisible = !isPanelVisible;
        panel.SetActive(isPanelVisible);
        overlay.SetActive(isPanelVisible);


        if (isPanelVisible)
        {
            canvasGroup.blocksRaycasts = true;
            overlayCanvasGroup.blocksRaycasts = true;
        }
        else
        {
            canvasGroup.blocksRaycasts = false;
            overlayCanvasGroup.blocksRaycasts = false;
        }
    }
}
