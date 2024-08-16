using System.Collections.Generic;
using UnityEngine;

public class CustomFloor : MonoBehaviour
{
    public static CustomFloor Instance { get; private set; }
    private List<GameObject> tiles = new List<GameObject>();

    [SerializeField] private GameObject baseobj;
    [SerializeField] private GameObject spawnobj;

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
    private void Start()
    {
        AddTile(baseobj);
        AddTile(spawnobj);
    }

    public void AddTile(GameObject tile)
    {
        tiles.Add(tile);
        Debug.Log("Å¸ÀÏ Ãß°¡µÊ.");
    }

    public void RemoveTile(int index)
    {
        if (index >= 0 && index < tiles.Count)
        {
            GameObject tile = tiles[index];
            tiles.RemoveAt(index);
            Destroy(tile);
            Debug.Log("Å¸ÀÏ Á¦°ÅµÊ.");
        }
    }
    public int IsNormalTileExistAt(Vector3 position)
    {
        for (int i = 0; i < tiles.Count; i++)
        {
            if (tiles[i] != null)
            {
                if (Vector3.Distance(tiles[i].transform.position, position) < 0.1f && !tiles[i].CompareTag("SpecificTile"))
                {
                    return i;
                }
            }
        }
        return -1;
    }

    public bool IsSpecificTileAt(Vector3 position)
    {
        for (int i = 0; i < tiles.Count; i++)
        {
            if (tiles[i] != null)
            {
                if (Vector3.Distance(tiles[i].transform.position, position) < 0.1f && tiles[i].CompareTag("SpecificTile"))
                {
                    return true;
                }
            }
        }
        return false;
    }

    public int IsSpecificTileExistAt(Vector3 position)
    {
        for (int i = 0; i < tiles.Count; i++)
        {
            if (tiles[i] != null)
            {
                if (Vector3.Distance(tiles[i].transform.position, position) < 0.1f && tiles[i].CompareTag("SpecificTile"))
                {
                    return i;
                }
            }
        }
        return -1;
    }

    public bool IsAnyTileAt(Vector3 position)
    {
        for (int i = 0; i < tiles.Count; i++)
        {
            if (Vector3.Distance(tiles[i].transform.position, position) < 0.1f)
            {
                return true;
            }
        }
        return false;
    }
    public bool IsRandomTileAt(Vector3 position)
    {
        for (int i = 0; i < tiles.Count; i++)
        {
            if (tiles[i] != null)
            {
                if (Vector3.Distance(tiles[i].transform.position, position) < 0.1f && tiles[i].CompareTag("RandomTile"))
                {
                    return true;
                }
            }
        }
        return false;
    }
    public bool IsSpecialAt(Vector3 position)
    {
        for (int i = 0; i < tiles.Count; i++)
        {
            if (tiles[i] != null)
            {
                if (Vector3.Distance(tiles[i].transform.position, position) < 0.1f && tiles[i].CompareTag("Special"))
                {
                    return true;
                }
            }
        }
        return false;
    }
    public GameObject GetTileAt(int index)
    {
        if (index >= 0 && index < tiles.Count)
        {
            return tiles[index];
        }
        return null;
    }
}
