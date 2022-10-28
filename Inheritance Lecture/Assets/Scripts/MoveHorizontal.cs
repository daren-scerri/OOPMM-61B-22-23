using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MoveVertical))]


public class MoveHorizontal : MonoBehaviour
{
    [SerializeField] float xspeed = 0;

    MoveVertical mymovevertical;

    // Start is called before the first frame update
    void Start()
    {
        mymovevertical = GetComponent<MoveVertical>();
    }

    // Update is called once per frame
    void Update()
    {
        mymovevertical.yspeed = mymovevertical.yspeed - 0.05f;
        transform.Translate(xspeed * Time.deltaTime,0 , 0);
    }
}
