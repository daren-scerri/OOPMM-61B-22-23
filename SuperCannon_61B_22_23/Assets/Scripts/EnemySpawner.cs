using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<EnemySO> myenemiesList;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());  
        
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            int enemychoice = Random.Range(0, myenemiesList.Count);
            Vector3 spawnpos = new Vector3(Random.Range(GameData.XMin, GameData.XMax), GameData.YMax, 0);
            GameObject spawnedEnemy = Instantiate(myenemiesList[enemychoice].EnemyGO, spawnpos, Quaternion.identity);
            spawnedEnemy.GetComponent<Enemy>().health = myenemiesList[enemychoice].strength;
            yield return new WaitForSeconds(1f);
        }
        
    }

    
}
