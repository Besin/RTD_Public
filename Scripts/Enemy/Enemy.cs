using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private EnemyData enemyData;
    public EnemyData EnemyData { get { return enemyData; } set { enemyData = value; } }
    
    private ChaseToBase chase;

    private bool isDie = false;

    public Sprite image;
    private float hp;
    private float def;
    private float speed;
    private bool isFly = false;

    private int round = 0;

    private BoxCollider2D boxCollider2D;

    private void Awake()
    {
        chase = GetComponent<ChaseToBase>();
        if (enemyData != null)
        {
            Init(enemyData);
        }
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void OnEnable()
    {
        isDie = false;

        if (isFly == true)
        {
            boxCollider2D.isTrigger = true;
        }
        else
        {
            boxCollider2D.isTrigger = false;
        }
    }

    private void Die()
    {
        EnemyManager.Instance.AddEnemyCount(-1);
        GameManager.Instance.AddMoney(10);
        if (EnemyManager.Instance.EnemyCount == 0)
        {
            GameManager.Instance.Progress.OnNextRound();
        }
        //TODO : 추후에 오브젝트풀로 변경 예정.
        Destroy(gameObject);
    }

    public void TakeDamage(float damage)
    {
        this.hp -= damage;

        if (this.hp <= 0 && isDie == false)
        {
            isDie = true;
            Die();
        }
    }

    public void Init(EnemyData enemyData)
    {
        this.enemyData = enemyData;
        this.image = enemyData.image;
        SpriteRenderer spriteR = gameObject.GetComponent<SpriteRenderer>();
        spriteR.sprite = image;

        hp = enemyData.hp + (enemyData.hp * (GameManager.Instance.Round - 1) * 0.1f);
        def = enemyData.def;
        speed = enemyData.speed;
        isFly = enemyData.isFly;
        chase.IsFlyCheck();
    }
}
