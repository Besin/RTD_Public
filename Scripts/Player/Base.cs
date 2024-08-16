using TMPro;
using UnityEngine;

public class Base : SpecialTile
{
    public TextMeshProUGUI life;

    protected override float RandomX()
    {
        float x;
        randomX = Random.Range(-8, -6);
        x = randomX - 0.5f;
        return x;
    }
    private void Start()
    {
        pos = new Vector3(RandomX(), RandomY());
        gameObject.transform.position = pos;
        GameManager.Instance.baseTransform = gameObject.transform;
    }
    private void Update()
    {
        life.text = GameManager.Instance.Life.ToString();
    }
}
