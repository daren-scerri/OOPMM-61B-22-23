using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAtCorners : MonoBehaviour
{
    public GameObject myprefab;
    float xmin, xmax, ymin, ymax;

    public float padding;

    // Start is called before the first frame update
    void Start()
    {

        Camera myCamera = Camera.main;
        xmin = myCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        xmax = myCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        ymin = myCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        ymax = myCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;

        Debug.Log("XMin: " + xmin.ToString());
        Debug.Log("XMax: " + xmax.ToString());
        Debug.Log("YMin: " + ymin.ToString());
        Debug.Log("YMax: " + ymax.ToString());

        Instantiate(myprefab, new Vector3(xmin + padding, ymin + padding, 0), Quaternion.identity);
        Instantiate(myprefab, new Vector3(xmin + padding , ymax - padding, 0), Quaternion.identity);
        Instantiate(myprefab, new Vector3(xmax - padding , ymin + padding, 0), Quaternion.identity);
        Instantiate(myprefab, new Vector3(xmax - padding , ymax - padding, 0), Quaternion.identity);


    }

    // Update is called once per frame
    void Update()
    {
  
    }
}
