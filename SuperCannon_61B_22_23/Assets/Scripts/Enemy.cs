using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int starthealth, scorevalue;
    int health;
    //public int scorereward, speed, strength; 
    // Start is called before the first frame update
    void Start()
    {
        health = starthealth;
        Debug.Log("Starting health:" + starthealth.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("Bullet"))
        {
            other.gameObject.SetActive(false);
            
            health--;
            Debug.Log("Score: " + GameData.Score.ToString());
            if (health <= 0)
            {
                GameData.Score += scorevalue;
                GameManager.Instance.DisplayScore();
                Destroy(this.gameObject);
          
            }
                

        }
    }

}
