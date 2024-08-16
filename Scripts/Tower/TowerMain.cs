using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerMain : MonoBehaviour
{
    public float attackRadius = 5f;
    public float attackInterval = 2f;
    public int damage = 10;
    public GameObject bulletPrefab;
    public GameObject bullet2Prefab;
    public Transform firePoint;
    public float attackRange = 3f;

    public int level = 1;
    public int attackDamage = 10;
    private TowerManager towerManager;
    private Enemy targetEnemy;
    private float attackTimer = 0f;

    protected float attackCooldown = 0f;

    protected Transform target;
    private float attackSpeed;

    private void Start()
    {
        attackInterval -= TalentManager.Instance.Tal1TowerAttackSpeed(attackInterval);
        attackDamage += TalentManager.Instance.Tal2TowerAttackPower(attackDamage);
        attackInterval -= TalentManager.Instance.Tal1TowerAttackSpeed(attackInterval);
        damage += TalentManager.Instance.Tal2TowerAttackPower(damage);
    }

    protected virtual void UpdateTarget()
    {

    }

    protected virtual void Attack()
    {
        if (target == null) return;
    }

    protected virtual void Update()
    {
        if (target == null)
        {
            UpdateTarget();
        }

        if (attackCooldown <= 0f)
        {
            Attack();
            attackCooldown = 1f / attackSpeed;
        }

        attackCooldown -= Time.deltaTime;
    }
}
