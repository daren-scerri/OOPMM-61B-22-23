using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{

    Animator myAnimation;
    bool lookLeft = false;
    Vector3 myScale;

    // Start is called before the first frame update
    void Start()
    {
        myAnimation = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        myScale = this.transform.localScale;
        myAnimation.SetBool("Walk", false);
        myAnimation.SetBool("Crouch", false);

        if (Input.GetKey(KeyCode.D))  //move and animate to the right
        {
            myAnimation.SetBool("Walk", true);
            GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 0f);
            if (lookLeft==true)
            {
                myScale.x *= -1;
                lookLeft = false;
                transform.localScale = myScale;
            }
           
        }

        if (Input.GetKey(KeyCode.A))  //move and animate to the left
        {
            myAnimation.SetBool("Walk", true);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, 0f);
            if (lookLeft == false)
            {
                myScale.x *= -1;
                lookLeft = true;
                transform.localScale = myScale;
            }
            
        }


        if (Input.GetKey(KeyCode.S))
        {
            myAnimation.SetBool("Crouch", true);
        }


    }


}
