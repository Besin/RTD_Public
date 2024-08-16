using UnityEngine;

public class TileManager : MonoBehaviour
{
    public static TileManager Instance { get; private set; }
    public GameObject specificTilePrefab;
    public GameObject drawTile;

    public ToGrid toGrid;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetCurrentTile(GameObject tilePrefab)
    {
        if (tilePrefab != null)
        {
            drawTile = tilePrefab;
            ToGrid toGrid = FindObjectOfType<ToGrid>();
            if (toGrid != null)
            {
                toGrid.SetDrawTile(tilePrefab);
                Debug.Log($"SetCurrentTile 호출됨: {drawTile.name}");
            }
            else
            {
                Debug.LogError("SetCurrentTile 실패: ToGrid를 찾을 수 없습니다.");
            }
        }
        else
        {
            Debug.LogWarning("SetCurrentTile 실패: tilePrefab이 null입니다.");
        }
    }

    public void ToggleRemoveMode()
    {
        ToGrid toGrid = FindObjectOfType<ToGrid>();
        if (toGrid != null)
        {
            toGrid.ToggleRemoveMode();
        }
        else
        {
            Debug.LogError("제거 모드 실패: ToGrid를 찾을 수 없습니다.");
        }
    }
}
