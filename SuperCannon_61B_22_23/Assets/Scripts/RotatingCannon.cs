using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class RotatingCannon : MonoBehaviour
{
    public GameObject mysmallbulletprefab;
    // public Transform cannontip;
    Vector3 mousePos;

    Quaternion newRotation, clampRotLow, clampRotHigh;

    // Start is called before the first frame update
    void Start()
    {
        clampRotLow = Quaternion.Euler(0, 0, -70);
        clampRotHigh = Quaternion.Euler(0, 0, 70);
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = GameData.MousePos;
        newRotation = Quaternion.LookRotation(this.gameObject.transform.position - mousePos, Vector3.forward);
        newRotation.x = 0f;
        newRotation.y = 0f;
        newRotation.z = Mathf.Clamp(newRotation.z, clampRotLow.z, clampRotHigh.z);
        newRotation.w = Mathf.Clamp(newRotation.w, clampRotLow.w, clampRotHigh.w);

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, newRotation, Time.deltaTime * 3f);
    
        if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            Instantiate(mysmallbulletprefab, this.transform.GetChild(0).position, Quaternion.identity);
        }
    }
}