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
        tmp.text = "��� ������ ����Ʈ : " + DataManager.Instance.TalentData.point.ToString();
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
        //TODO ���Ŀ� ������ƮǮ�� ����� �����ؾ��� �ʿ䰡 ����, �׸��� �ý��� �޼����� ��ġ�� �ʰ� ���̾ƿ� ���� ����ϴ� �͵� ����غ� ��
    }
}
