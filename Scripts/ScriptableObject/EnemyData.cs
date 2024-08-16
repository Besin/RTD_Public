using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "New Enemy")]
public class EnemyData : ScriptableObject
{
    public Sprite image;

    public string enemyName;
    public float hp;
    public float def;
    public float speed;
    public bool isFly;
}
