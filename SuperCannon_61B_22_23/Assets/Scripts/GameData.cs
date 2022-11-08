using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public abstract class GameData : MonoBehaviour
{
    public static Vector3 MousePos
    {
        get { return GetMousePos(); }
    }

    static Vector3 GetMousePos()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(CrossPlatformInputManager.mousePosition)
            - Camera.main.transform.position;
        Debug.Log(mousePos);
        return mousePos;
    }

    /*
    public int damage
    {
        get { return m_damage; }
        set { m_damage = value; }
    }
    */


}
