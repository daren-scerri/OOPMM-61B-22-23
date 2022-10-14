using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDrag : MonoBehaviour
{
    Vector3 mousepos;



    private void OnMouseDrag()
    {
        
            mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - new Vector3(0f, 0f, -10f);
            this.gameObject.transform.position = mousepos;
       
    }
}
