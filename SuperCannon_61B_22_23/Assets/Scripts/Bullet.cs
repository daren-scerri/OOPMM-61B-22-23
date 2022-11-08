using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    Vector3 mousePos;
    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        mousePos = GameData.MousePos;
        direction = new Vector2(mousePos.x, mousePos.y - transform.position.y);
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
