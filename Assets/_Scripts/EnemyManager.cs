using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager instance;

    public GameObject enemy1;
    public GameObject enemy2;

    private EnemyController enemyController1;
    private EnemyController enemyController2;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        enemyController1 = enemy1.GetComponent<EnemyController>();
        enemyController2 = enemy2.GetComponent<EnemyController>();
    }

    public void ScareEnemies()
    {
        enemyController1.GetScared();
        enemyController2.GetScared();
    }
}
