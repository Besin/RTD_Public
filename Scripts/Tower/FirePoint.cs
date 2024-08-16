using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoint : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireRate = 1f;
    public float bulletSpeed = 10f;

    private Transform firePoint;
    private Transform target;
    private float fireTimer = 0f;
    void Start()
    {
        if (transform.childCount > 0)
        {
            firePoint = transform.GetChild(0);
        }
        else
        {
            Debug.LogError("No firePoint set for the tower!");
        }
    }

    void Update()
    {
        fireTimer += Time.deltaTime;
        if (fireTimer >= fireRate && target != null)
        {
            Fire();
            fireTimer = 0f;
        }
    }

    void Fire()
    {
        GameObject bulletGO = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        if (bullet != null)
        {
            bullet.Seek(target);
            bullet.SetSpeed(bulletSpeed);
        }
        else
        {
            Debug.LogWarning("No Bullet component found on the bulletPrefab!");
        }
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}