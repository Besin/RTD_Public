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
                Debug.Log($"SetCurrentTile ȣ���: {drawTile.name}");
            }
            else
            {
                Debug.LogError("SetCurrentTile ����: ToGrid�� ã�� �� �����ϴ�.");
            }
        }
        else
        {
            Debug.LogWarning("SetCurrentTile ����: tilePrefab�� null�Դϴ�.");
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
            Debug.LogError("���� ��� ����: ToGrid�� ã�� �� �����ϴ�.");
        }
    }
}
