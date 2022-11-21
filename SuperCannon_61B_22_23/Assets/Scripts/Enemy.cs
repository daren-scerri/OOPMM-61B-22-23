using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health;
    //public int scorereward, speed, strength; 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting health:" + health.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
