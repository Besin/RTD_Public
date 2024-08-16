using UnityEngine;

public class TileButton : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    public TileManager tileManager;

    private bool isFirstTileModeActive = false;
    private bool isSecondTileModeActive = false;
    private bool isSpecificTileModeActive = false;
    private bool isRemoveModeActive = false;

    private void Start()
    {
        tileManager = FindObjectOfType<TileManager>();
    }

    // ��� ��带 ��Ȱ��ȭ�ϴ� �޼���
    private void DisableAllModes()
    {
        isFirstTileModeActive = false;
        isSecondTileModeActive = false;
        isSpecificTileModeActive = false;
        isRemoveModeActive = false;
    }

    // ù ��° Ÿ�� ��ư Ŭ�� �� ȣ��� �޼���
    public void OnFirstTileButton()
    {
        if (tileManager != null)
        {
            tileManager.SetCurrentTile(prefab1);
            DisableAllModes();
            isFirstTileModeActive = true;
            Debug.Log("First tile mode Ȱ��ȭ");
        }
    }

    // �� ��° Ÿ�� ��ư Ŭ�� �� ȣ��� �޼���
    public void OnSecondTileButton()
    {
        if (tileManager != null)
        {
            tileManager.SetCurrentTile(prefab2);
            DisableAllModes();
            isSecondTileModeActive = true;
            Debug.Log("Second tile mode Ȱ��ȭ");
        }
    }

    // Ư�� Ÿ�� ��� ��ư Ŭ�� �� ȣ��� �޼���
    public void OnToggleSpecificTileButton()
    {
        if (tileManager != null)
        {
            ToGrid toGrid = FindObjectOfType<ToGrid>();
            if (toGrid != null)
            {
                toGrid.ToggleSpecificTileMode();
                DisableAllModes();
                isSpecificTileModeActive = true;
                Debug.Log("Specific tile mode Ȱ��ȭ");
            }
        }
    }

    // Ÿ�� ���� ��� ��ư Ŭ�� �� ȣ��� �޼���
    public void OnRemoveTileButton()
    {
        if (tileManager != null)
        {
            tileManager.ToggleRemoveMode();
            DisableAllModes();
            isRemoveModeActive = true;
            Debug.Log("Remove mode Ȱ��ȭ");
        }
    }
}
