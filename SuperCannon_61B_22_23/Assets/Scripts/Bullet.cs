using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(Rigidbody2D))]

public class Bullet : MonoBehaviour
{
    [SerializeField] protected float speed = 10f;
    Vector3 mousePos;
    Vector2 direction;
    // Start is called before the first frame update
    protected virtual void OnEnable()
    {
        mousePos = GameData.MousePos;
        direction = new Vector2(mousePos.x, mousePos.y - transform.position.y);
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }


}
