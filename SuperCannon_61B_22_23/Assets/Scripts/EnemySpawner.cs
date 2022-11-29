using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner :MonoBehaviour
{
    public List<EnemySO> myenemiesList;
    // Start is called before the first frame update

    //SINGLETON PATTERN using Awake() method in same class.

    public static EnemySpawner _instance;

    private void Awake()
    {
        if (_instance == null)    //SINGLETON PATTERN
        {
            _instance = this;
        }
        else if (_instance != this)
        {
            Destroy(this.gameObject);
        }
    }



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
            spawnedEnemy.GetComponent<Enemy>().starthealth = myenemiesList[enemychoice].strength;
            spawnedEnemy.GetComponent<Enemy>().scorevalue = myenemiesList[enemychoice].scoreReward;
            yield return new WaitForSeconds(1f);
        }
        
    }

    
}
