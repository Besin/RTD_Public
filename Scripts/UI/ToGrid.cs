using UnityEngine;
using UnityEngine.EventSystems;

public class ToGrid : MonoBehaviour
{
    public CustomFloor editFloor;
    private bool toggleSpecificTileMode = false;
    private bool isRemoveMode = false;
    private GameObject drawTile;

    private void Start()
    {
        editFloor = FindObjectOfType<CustomFloor>();
        if (editFloor == null)
        {
            Debug.LogError("ToGrid 초기화 실패: CustomFloor를 찾을 수 없습니다.");
        }
    }

    private void Update()
    {
        if (editFloor == null) return;

        if ((Input.GetMouseButtonDown(0) || Input.touchCount > 0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Vector3 position = Input.GetMouseButtonDown(0) ? MousePosToGridPos(Input.mousePosition) : TouchPosToGridPos(Input.GetTouch(0).position);
            if (IsValidPos(position))
            {
                if (isRemoveMode) RemoveTile(position);
                else if (toggleSpecificTileMode) ToggleSpecificTile(position);
                else CreateTile(position);
            }
        }
    }

    public void SetDrawTile(GameObject tilePrefab)
    {
        drawTile = tilePrefab;
        toggleSpecificTileMode = false;
        isRemoveMode = false;
        Debug.Log($"SetDrawTile 호출됨: {drawTile.name}");
    }

    public void ToggleRemoveMode()
    {
        isRemoveMode = !isRemoveMode;
        toggleSpecificTileMode = false;
        Debug.Log($"Remove mode 전환됨: {isRemoveMode}");
    }

    public void ToggleSpecificTileMode()
    {
        toggleSpecificTileMode = !toggleSpecificTileMode;
        isRemoveMode = false;
        Debug.Log($"Specific tile mode 전환됨: {toggleSpecificTileMode}");
    }

    public void CreateTile(Vector3 position)
    {
        if (drawTile == null)
        {
            Debug.LogWarning("CreateTile 실패: drawTile이 null입니다.");
            return;
        }

        // 랜덤 타일이 있는지 체크
        if (editFloor.IsRandomTileAt(position))
        {
            UIManager.Instance.OnSystemMassage("랜덤 타일 위에는 다른 타일을 설치할 수 없습니다.");
            return;
        }

        if (drawTile.CompareTag("SpecificTile"))
        {
            if (GameManager.Instance.available(10))
            {
                GameObject tile = Instantiate(drawTile, position, Quaternion.identity, editFloor.transform);
                tile.tag = "SpecificTile";
                editFloor.AddTile(tile);
                GameManager.Instance.SpendMoney(10);
                Debug.Log($"Specific tile 생성됨: 위치 {position}");
            }
            else
            {
                UIManager.Instance.OnSystemMassage("자금이 부족합니다.");
            }
        }
        else
        {
            if (editFloor.IsSpecificTileAt(position))
            {
                if (editFloor.IsNormalTileExistAt(position) != -1)
                {
                    UIManager.Instance.OnSystemMassage("이미 설치된 포탑이 존재합니다.");
                    return;
                }

                if (GameManager.Instance.available(30))
                {
                    GameObject tile = Instantiate(drawTile, position, Quaternion.identity, editFloor.transform);
                    editFloor.AddTile(tile);
                    GameManager.Instance.SpendMoney(30);
                }
                else
                {
                    UIManager.Instance.OnSystemMassage("자금이 부족합니다.");
                }
            }
            else
            {
                UIManager.Instance.OnSystemMassage("포탑을 설치할 토대가 없습니다.");
            }
        }
    }

    public void ToggleSpecificTile(Vector3 position)
    {
        if (TileManager.Instance.specificTilePrefab != null)
        {
            if (editFloor.IsRandomTileAt(position))
            {
                UIManager.Instance.OnSystemMassage("랜덤 타일 위에는 타일을 설치할 수 없습니다.");
                return;
            }

            if (editFloor.IsSpecificTileAt(position))
            {
                UIManager.Instance.OnSystemMassage("이미 설치된 토대가 존재합니다.");
                return;
            }
            if (editFloor.IsSpecialAt(position))
            {
                UIManager.Instance.OnSystemMassage("적 베이스위에는 다른 타일을 설치할 수 없습니다.");
                return;
            }
            if (GameManager.Instance.available(10))
            {
                GameObject tile = Instantiate(TileManager.Instance.specificTilePrefab, position, Quaternion.identity, editFloor.transform);
                tile.tag = "SpecificTile";
                editFloor.AddTile(tile);
                GameManager.Instance.SpendMoney(10);
            }
            else
            {
                UIManager.Instance.OnSystemMassage("자금이 부족합니다.");
            }
        }
        else
        {
            Debug.LogWarning("Specific tile prefab이 설정되지 않았습니다.");
        }
    }

    public void RemoveTile(Vector3 position)
    {
        int normalTileIndex = editFloor.IsNormalTileExistAt(position);
        if (normalTileIndex != -1)
        {
            GameObject tile = editFloor.GetTileAt(normalTileIndex);
            if (tile.CompareTag("RandomTile"))
            {
                UIManager.Instance.OnSystemMassage("랜덤 타일은 제거할 수 없습니다.");
                return;
            }
            Destroy(tile);
            editFloor.RemoveTile(normalTileIndex);
            GameManager.Instance.AddMoney(10);
            Debug.Log($"일반 타일 제거됨: 위치 {position}");
        }
        else
        {
            int specificTileIndex = editFloor.IsSpecificTileExistAt(position);
            if (specificTileIndex != -1)
            {
                GameObject tile = editFloor.GetTileAt(specificTileIndex);
                if (tile.CompareTag("RandomTile"))
                {
                    UIManager.Instance.OnSystemMassage("랜덤 타일은 제거할 수 없습니다.");
                    return;
                }
                Destroy(tile);
                editFloor.RemoveTile(specificTileIndex);
                GameManager.Instance.AddMoney(10);
                Debug.Log($"Specific tile 제거됨: 위치 {position}");
            }
        }
    }

    private Vector3 MousePosToGridPos(Vector2 clickPos)
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        worldPos.x = Mathf.Floor(worldPos.x) + 0.5f;
        worldPos.y = Mathf.Floor(worldPos.y) + 0.5f;
        worldPos.z = 0;
        return worldPos;
    }

    private Vector3 TouchPosToGridPos(Vector2 touchPos)
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(touchPos);
        worldPos.x = Mathf.Floor(worldPos.x) + 0.5f;
        worldPos.y = Mathf.Floor(worldPos.y) + 0.5f;
        worldPos.z = 0;
        return worldPos;
    }

    private bool IsValidPos(Vector3 position)
    {
        float left = -8.5f;
        float right = 7.5f;
        float top = 5.5f;
        float bottom = -4.5f;

        return position.x >= left && position.x <= right && position.y >= bottom && position.y <= top;
    }
}
