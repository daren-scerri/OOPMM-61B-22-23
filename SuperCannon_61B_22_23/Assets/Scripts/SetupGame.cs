using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupGame : Singleton<SetupGame>
{
    private GameObject vertWallPrefab, horizWallPrefab;
    // Start is called before the first frame update
    void Start()
    {
        vertWallPrefab = Resources.Load("prefabs/VerticalWall") as GameObject;
        horizWallPrefab = Resources.Load("prefabs/HorizWall") as GameObject;

        Instantiate(vertWallPrefab, new Vector3(GameData.XMin - 5, 0, 0), Quaternion.identity, this.gameObject.transform);
        Instantiate(vertWallPrefab, new Vector3(GameData.XMax + 5, 0, 0), Quaternion.identity, this.gameObject.transform);
        Instantiate(horizWallPrefab, new Vector3(0, GameData.YMin - 5, 0), Quaternion.identity, this.gameObject.transform);
        Instantiate(horizWallPrefab, new Vector3(0, GameData.YMax + 5, 0), Quaternion.identity, this.gameObject.transform);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
