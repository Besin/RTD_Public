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

    // 모든 모드를 비활성화하는 메서드
    private void DisableAllModes()
    {
        isFirstTileModeActive = false;
        isSecondTileModeActive = false;
        isSpecificTileModeActive = false;
        isRemoveModeActive = false;
    }

    // 첫 번째 타일 버튼 클릭 시 호출될 메서드
    public void OnFirstTileButton()
    {
        if (tileManager != null)
        {
            tileManager.SetCurrentTile(prefab1);
            DisableAllModes();
            isFirstTileModeActive = true;
            Debug.Log("First tile mode 활성화");
        }
    }

    // 두 번째 타일 버튼 클릭 시 호출될 메서드
    public void OnSecondTileButton()
    {
        if (tileManager != null)
        {
            tileManager.SetCurrentTile(prefab2);
            DisableAllModes();
            isSecondTileModeActive = true;
            Debug.Log("Second tile mode 활성화");
        }
    }

    // 특정 타일 모드 버튼 클릭 시 호출될 메서드
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
                Debug.Log("Specific tile mode 활성화");
            }
        }
    }

    // 타일 제거 모드 버튼 클릭 시 호출될 메서드
    public void OnRemoveTileButton()
    {
        if (tileManager != null)
        {
            tileManager.ToggleRemoveMode();
            DisableAllModes();
            isRemoveModeActive = true;
            Debug.Log("Remove mode 활성화");
        }
    }
}
