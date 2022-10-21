using UnityEngine;
using System.Collections;
public class Enemy : MonoBehaviour
{
    public int hitpoints, damage;
    public string name;


    public void TakeDamage()
    {
        hitpoints--; //reduce HP by 1
        Debug.Log(name + "'s HP: " + hitpoints); //print out new hp
        GetComponent<SpriteRenderer>().color =
            GetComponent<SpriteRenderer>().color - new Color(0f, 0.2f, 0f, 0f);
    }
    public void Die()
    {
        Debug.Log(name + " Has Died"); //print to the console
    }
}
