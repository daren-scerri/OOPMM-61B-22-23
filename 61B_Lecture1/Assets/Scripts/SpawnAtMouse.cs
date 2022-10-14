using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAtMouse : MonoBehaviour
{
    public GameObject myprefab;

    Vector3 mousepos;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && count < 5)
        {
            count++;
            mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousepos = new Vector3(mousepos.x, mousepos.y, 0f);  //RESET Z to 0
            Instantiate(myprefab, mousepos, Quaternion.identity);
        }
        
    }
}
