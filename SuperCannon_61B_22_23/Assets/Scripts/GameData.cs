using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public abstract class GameData : MonoBehaviour
{
    static int  _score = 0;
    public static int Score
    {
        get { return _score; }
        set { _score = value; }
    }

    public static Vector3 MousePos
    {
        get { return GetMousePos(); }
    }

    public static float XMin
    {
        get {  return Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x; }
    }

    public static float XMax
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x; }
    }

    public static float YMin
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y; }
    }

    public static float YMax
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y; }
    }

    static Vector3 GetMousePos()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(CrossPlatformInputManager.mousePosition)
            - Camera.main.transform.position;
      //  Debug.Log(mousePos);
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
