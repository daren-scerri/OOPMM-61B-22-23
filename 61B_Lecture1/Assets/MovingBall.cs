using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBall : MonoBehaviour
{
    Vector2 newvelocity;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(400f, 600f) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime.ToString());
    }
}
