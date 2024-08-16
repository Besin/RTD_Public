using UnityEngine;

public class EnemyBase : SpecialTile
{
    protected override float RandomX()
    {
        float x;
        randomX = Random.Range(6, 8);
        x = randomX + 0.5f;
        return x;
    }
    private void Start()
    {
        pos = new Vector3(RandomX(), RandomY());
        gameObject.transform.position = pos;
    }
}
