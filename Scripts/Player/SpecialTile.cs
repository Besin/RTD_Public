using UnityEngine;
using UnityEngine.Tilemaps;

public class SpecialTile : MonoBehaviour
{
    protected int randomX;
    protected int randomY;

    protected Vector3 pos;

    protected virtual float RandomX()
    {
        return randomX;
    }
    protected float RandomY()
    {
        float y;
        randomY = Random.Range(-5, 7);
        if (randomY < 0)
        {
            y = randomY + 0.5f;
            return y;
        }
        else if (randomY >= 0)
        {
            y = randomY - 0.5f;
            return y;
        }
        return 0.5f;
    }
}
