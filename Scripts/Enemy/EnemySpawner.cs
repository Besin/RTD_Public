using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //기본 몬스터
    public GameObject enemyPrefab;
    public GameObject[] enemyObject;

    public EnemyData[] data;

    public float intervaltime = 2f;

    private int count = 0;

    public void SpawnEnemyAttack()
    {
        StartCoroutine(SpawnStart(GameManager.Instance.Progress.OnEnemyType()));
    }

    private IEnumerator SpawnStart(int num)
    {
        AttackType1 attackType1 = new AttackType1();
        AttackType2 attackType2 = new AttackType2();
        AttackType3 attackType3 = new AttackType3();
        AttackType4 attackType4 = new AttackType4();
        AttackType5 attackType5 = new AttackType5();

        switch (num)
        {
            case 0:
                attackType1.Spawn(data);
                break;
            case 1:
                attackType2.Spawn(data);
                break;
            case 2:
                attackType3.Spawn(data);
                break;
            case 3:
                attackType4.Spawn(data);
                break;
            case 4:
                attackType5.Spawn(data);
                break;
        }

        EnemyManager.Instance.AddEnemyCount(30);
        for (int i = 0; i < 30; i++)
        {
            yield return new WaitForSeconds(intervaltime);
            enemyObject[count].transform.position = EnemyManager.Instance.spawner.transform.position;
            enemyObject[count].SetActive(true);
            count++;
            if (count == 30)
            {
                count = 0;
            }
        }
    }

    public abstract class SpawnEnemy
    {
        public abstract void Spawn(EnemyData[] enemyData);
    }

    public class AttackType1 : SpawnEnemy // 노말, 체력 2배
    {
        public override void Spawn(EnemyData[] enemyData)
        {
            EnemyManager.Instance.Spawner.enemyObject = new GameObject[30];
            for (int i = 0; i < 30; i++)
            {
                GameObject go = Instantiate(EnemyManager.Instance.Spawner.enemyPrefab, EnemyManager.Instance.spawner.transform);
                if (i % 5 == 4)
                {
                    go.GetComponent<Enemy>().Init(enemyData[1]);
                }
                else
                {
                    go.GetComponent<Enemy>().Init(enemyData[0]);
                }
                EnemyManager.Instance.Spawner.enemyObject[i] = go;
                go.SetActive(false);
            }
        }
    }

    public class AttackType2 : SpawnEnemy // 노말, 이속 2배
    {
        public override void Spawn(EnemyData[] enemyData)
        {
            EnemyManager.Instance.Spawner.enemyObject = new GameObject[30];
            for (int i = 0; i < 30; i++)
            {
                GameObject go = Instantiate(EnemyManager.Instance.Spawner.enemyPrefab, EnemyManager.Instance.spawner.transform);
                if (i % 5 == 4)
                {
                    go.GetComponent<Enemy>().Init(enemyData[2]);
                }
                else
                {
                    go.GetComponent<Enemy>().Init(enemyData[0]);
                }
                EnemyManager.Instance.Spawner.enemyObject[i] = go;
                go.SetActive(false);
            }
        }
    }

    public class AttackType3 : SpawnEnemy // 노말, 체력 2배, 이속 2배
    {
        public override void Spawn(EnemyData[] enemyData)
        {
            EnemyManager.Instance.Spawner.enemyObject = new GameObject[30];
            for (int i = 0; i < 30; i++)
            {
                GameObject go = Instantiate(EnemyManager.Instance.Spawner.enemyPrefab, EnemyManager.Instance.spawner.transform);
                if (i % 5 == 4)
                {
                    go.GetComponent<Enemy>().Init(enemyData[1]);
                }
                else if (i % 3 == 3)
                {
                    go.GetComponent<Enemy>().Init(enemyData[2]);
                }
                else
                {
                    go.GetComponent<Enemy>().Init(enemyData[0]);
                }
                EnemyManager.Instance.Spawner.enemyObject[i] = go;
                go.SetActive(false);
            }
        }
    }

    public class AttackType4 : SpawnEnemy // 노말, 지형무시
    {
        public override void Spawn(EnemyData[] enemyData)
        {
            EnemyManager.Instance.Spawner.enemyObject = new GameObject[30];
            for (int i = 0; i < 30; i++)
            {
                GameObject go = Instantiate(EnemyManager.Instance.Spawner.enemyPrefab, EnemyManager.Instance.spawner.transform);
                if (i % 5 == 4)
                {
                    go.GetComponent<Enemy>().Init(enemyData[3]);
                }
                else
                {
                    go.GetComponent<Enemy>().Init(enemyData[0]);
                }
                EnemyManager.Instance.Spawner.enemyObject[i] = go;
                go.SetActive(false);
            }
        }
    }

    public class AttackType5 : SpawnEnemy // 노말, 이동 속도, 지형 무시
    {
        public override void Spawn(EnemyData[] enemyData)
        {
            EnemyManager.Instance.Spawner.enemyObject = new GameObject[30];
            for (int i = 0; i < 30; i++)
            {
                GameObject go = Instantiate(EnemyManager.Instance.Spawner.enemyPrefab, EnemyManager.Instance.spawner.transform);
                if (i % 5 == 4)
                {
                    go.GetComponent<Enemy>().Init(enemyData[2]);
                }
                else if (i % 3 == 3)
                {
                    go.GetComponent<Enemy>().Init(enemyData[3]);
                }
                else
                {
                    go.GetComponent<Enemy>().Init(enemyData[0]);
                }
                EnemyManager.Instance.Spawner.enemyObject[i] = go;
                go.SetActive(false);
            }
        }
    }
}
