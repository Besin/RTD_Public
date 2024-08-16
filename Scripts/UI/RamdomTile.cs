using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    public GameObject randomTilePrefab;
    public EnemyBase[] enemyBases;
    public CustomFloor editFloor; 

    private void Start()
    {
        editFloor = FindObjectOfType<CustomFloor>(); 
        GenerateRandomTiles(5);
    }

    private void GenerateRandomTiles(int count)
    {
        int tilesCreated = 0;

        while (tilesCreated < count)
        {
            Vector3 randomPosition = GetRandomPosition();

           
            if (!IsEnemyBaseAt(randomPosition) && !editFloor.IsAnyTileAt(randomPosition))
            {
                GameObject randomTile = Instantiate(randomTilePrefab, randomPosition, Quaternion.identity, editFloor.transform);
                randomTile.tag = "RandomTile";
                editFloor.AddTile(randomTile);
                tilesCreated++;
            }
        }
    }

    private Vector3 GetRandomPosition()
    {
        float x = Mathf.Floor(Random.Range(-8.5f, 7.5f)) + 0.5f;
        float y = Mathf.Floor(Random.Range(-4.5f, 5.5f)) + 0.5f;
        return new Vector3(x, y, 0);
    }

    private bool IsEnemyBaseAt(Vector3 position)
    {
        foreach (var enemyBase in enemyBases)
        {
            Vector3 enemyBasePosition = enemyBase.transform.position;
            if (Vector3.Distance(enemyBasePosition, position) < 0.1f)
            {
                return true;
            }
        }
        return false;
    }
}
