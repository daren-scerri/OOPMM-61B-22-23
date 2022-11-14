using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeBullet : Bullet
{

    protected override void OnEnable()
    {
        speed = 15f;
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        GetComponent<Rigidbody2D>().gravityScale = 1;
        base.OnEnable();
    }
}
