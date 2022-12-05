using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFiring : MonoBehaviour
{

    public void FireCannon(GameObject bullet)
    {
        bullet.transform.position = this.transform.position;
        bullet.transform.rotation = Quaternion.identity;
        bullet.SetActive(true);
  
    }
}
