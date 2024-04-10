using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public EnemyManager enemyManager;

    private void Start()
    {
        //finding the enemymanager in the game
         enemyManager = FindObjectOfType<EnemyManager>();
    }

    public void takedamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            //destroying this when dead
            if (enemyManager != null)
            {
                enemyManager.RemoveEnemy(this);
            }
            Destroy(gameObject);
        }
    }


}
