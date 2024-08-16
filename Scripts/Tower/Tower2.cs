using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower2 : TowerMain
{
    
    private TowerManager towerManager;
    private Enemy targetEnemy;
    private float attackTimer = 0f;

    void Start()
    {
        if (firePoint == null)
        {
            firePoint = transform;
        }

        towerManager = TowerManager.Instance;
        if (towerManager != null)
        {
            towerManager.RegisterTower2(this);
        }

        //TODO : Ư�� ���׷��̵忡 ���� �����Դϴ�. ����Ŭ������ ������ֽø� �������� �Ű��ּ���

    }
    void Update()
    {
        if (targetEnemy == null || !targetEnemy.isActiveAndEnabled || Vector2.Distance(transform.position, targetEnemy.transform.position) > attackRange)
        {
            targetEnemy = FindClosestEnemy();
        }
        if (targetEnemy != null)
        {
            attackTimer += Time.deltaTime;
            if (attackTimer >= attackInterval)
            {
                Attack();
                attackTimer = 0f;
            }
        }
    }

    Enemy FindClosestEnemy()
    {
        Enemy[] enemies = FindObjectsOfType<Enemy>();
        Enemy closestEnemy = null;
        float closestDistance = Mathf.Infinity;

        foreach (Enemy enemy in enemies)
        {
            float distance = Vector2.Distance(transform.position, enemy.transform.position);
            if (distance <= attackRange && distance < closestDistance)
            {
                closestEnemy = enemy;
                closestDistance = distance;
            }
        }

        return closestEnemy;
    }

    void Attack()
    {
        if (targetEnemy != null)
        {
            GameObject bulletGO = Instantiate(bullet2Prefab, firePoint.position, firePoint.rotation);
            Bullet bullet = bulletGO.GetComponent<Bullet>();
            if (bullet != null)
            {
                bullet.Seek(targetEnemy.transform);
            }
        }
    }

    void Shoot()
    {
        GameObject bulletGO = Instantiate(bullet2Prefab, firePoint.position, firePoint.rotation);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRadius);
    }
    public void Upgrade()
    {
        level++;
        attackDamage += 5;
        Debug.Log("Ÿ�� ���׷��̵� �Ϸ�. ���� ����: " + level + ", ���ݷ�: " + attackDamage);
    }
}