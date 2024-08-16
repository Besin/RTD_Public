using System.Collections;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (Instance != this)
            {
                Destroy(gameObject);
            }
        }
    }

    private GameObject canvas;

    [SerializeField] private GameObject systemMassge;
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject gameClaerUI;
    [SerializeField] private GameObject optionUI;
    [SerializeField] private GameObject howToPlayUI;
    [SerializeField] private GameObject pauseUI;
    [SerializeField] private GameObject TalentUI;

    private TextMeshProUGUI systemText;
    private GameObject pauseUIobj;


    private void Start()
    {
        systemText = systemMassge.GetComponentInChildren<TextMeshProUGUI>();
    }
    private void CachingCanvas()
    {
        if (canvas == null)
        {
            canvas = GameObject.Find("Canvas");
        }
    }
    public void UpdatePointUI(TextMeshProUGUI tmp)
    {
        tmp.text = "사용 가능한 포인트 : " + DataManager.Instance.TalentData.point.ToString();
    }
    public void OnGameOverUI()
    {
        CachingCanvas();
        Instantiate(gameOverUI, canvas.transform);
    }
    public void OnGameClaerUI()
    {
        CachingCanvas();
        Instantiate(gameClaerUI, canvas.transform);
    }
    public void OnOptionUI()
    {
        CachingCanvas();
        Instantiate(optionUI, canvas.transform);
    }
    public void OnHowToPlayUI()
    {
        CachingCanvas();
        Instantiate(howToPlayUI, canvas.transform);
    }
    public void OnPauseUI()
    {
        if (pauseUIobj == null)
        {
            CachingCanvas();
            pauseUIobj = Instantiate(pauseUI, canvas.transform);
        }
        else if (pauseUIobj != null && !pauseUIobj.activeInHierarchy)
        {
            pauseUIobj.SetActive(true);
        }
        else if (pauseUIobj != null && pauseUIobj.activeInHierarchy)
        {
            pauseUIobj.SetActive(false);
        }
    }
    public void OnTalentUI()
    {
        CachingCanvas();
        Instantiate(TalentUI, canvas.transform);
    }
    public void OnSystemMassage(string massage)
    {
        StartCoroutine(OnSystemCoroutine(massage));
    }

    private IEnumerator OnSystemCoroutine(string massage)
    {
        GameObject systemUI;
        systemText.text = massage;
        systemText.color = Color.black;

        CachingCanvas();

        systemUI = Instantiate(systemMassge, canvas.transform);

        yield return new WaitForSeconds(1);

        if (systemUI != null)
        {
            Destroy(systemUI);
        }
        //TODO 추후에 오브젝트풀을 사용해 개선해야할 필요가 있음, 그리고 시스템 메세지가 곂치지 않게 레이아웃 등을 사용하는 것도 고려해볼 것
    }
}
