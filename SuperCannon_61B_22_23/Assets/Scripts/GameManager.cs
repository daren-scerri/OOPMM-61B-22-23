using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{


    private GameObject vertWallPrefab, horizWallPrefab;
    // Start is called before the first frame update

    public Text scoreText;

    public override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        vertWallPrefab = Resources.Load("prefabs/VerticalWall") as GameObject;
        horizWallPrefab = Resources.Load("prefabs/HorizWall") as GameObject;

        Instantiate(vertWallPrefab, new Vector3(GameData.XMin - 5, 0, 0), Quaternion.identity, this.gameObject.transform);
        Instantiate(vertWallPrefab, new Vector3(GameData.XMax + 5, 0, 0), Quaternion.identity, this.gameObject.transform);
        Instantiate(horizWallPrefab, new Vector3(0, GameData.YMin - 5, 0), Quaternion.identity, this.gameObject.transform);
        Instantiate(horizWallPrefab, new Vector3(0, GameData.YMax + 5, 0), Quaternion.identity, this.gameObject.transform);

        GameData.Score = 0;
        DisplayScore();

    }

    public void DisplayScore()
    {
        scoreText.text = "Score: " + GameData.Score.ToString();
    }


}
