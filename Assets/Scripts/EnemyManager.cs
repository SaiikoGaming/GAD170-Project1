using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // creating list and such
    public GameObject enemyPrefab;
    public List<Enemy> allEnemies = new List<Enemy>();

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++) 
        {
            //spawning in random locations
            float x = Random.Range(-10f, 10f);
            float y = Random.Range(-10f, 10f);
            float z = Random.Range(-10f, 10f);
            Vector3 spawnPosition = new Vector3(x, y, z);
            GameObject clone = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
            allEnemies.Add(clone.GetComponent<Enemy>());
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            for(int i = 0; i < allEnemies.Count; i++)
            {
                //allEnemies[i].TakeDamage(20);
            }
        }
    }

    // removing an enemy
    public void RemoveEnemy(Enemy enemyToRemove)
    {
        allEnemies.Remove(enemyToRemove);
    }
}
