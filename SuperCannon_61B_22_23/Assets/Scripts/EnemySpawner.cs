using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemyprefabs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());  
        
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            int enemychoice = Random.Range(0, enemyprefabs.Count);
            Vector3 spawnpos = new Vector3(Random.Range(GameData.XMin, GameData.XMax), GameData.YMax, 0);
            Instantiate(enemyprefabs[enemychoice], spawnpos, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        
    }

    
}
