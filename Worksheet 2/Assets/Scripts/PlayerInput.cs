using UnityEngine;
using System.Collections;
public class PlayerInput : MonoBehaviour
{
    public GameObject prefab1, prefab2;

    GameObject bobGO, aliceGO;

    Enemy bob, alice;
    int playerHP = 10; //This is our hp
    void Start()
    {
        bobGO = Instantiate(prefab1, new Vector3(-3f, 0f, 0f), Quaternion.identity);
        aliceGO = Instantiate(prefab2, new Vector3(3f, 0f, 0f), Quaternion.identity);

        bob = bobGO.GetComponent<Enemy>();
        alice = aliceGO.GetComponent<Enemy>();

        bob.hitpoints = 5;
        bob.damage = 2;
        bob.name = "Bob";

        alice.hitpoints = 2;
        alice.damage = 5;
        alice.name = "Alice";

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            //Bob takes damage if Spacebar is pressed
            bob.TakeDamage();
        else if (Input.GetKeyDown(KeyCode.LeftShift))
            //Alice takes damage if left shift is pressed
            alice.TakeDamage();
        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            //Player takes damage from bob if left control is pressed
            playerHP -= bob.damage;
            Debug.Log("Player HP: " + playerHP);
        }
        else if (Input.GetKeyDown(KeyCode.LeftAlt))
       {
            //Player takes damage from alice if left alt is pressed
           playerHP -= alice.damage;
           Debug.Log("Player HP: " + playerHP);
       }

        if (bob.hitpoints < 1)
            //if bob's hp is under 1, he dies
            bob.Die();
        if (alice.hitpoints < 1)
            //if alice's hp is under 1, she dies
            alice.Die();
        if (playerHP < 1)
            //if our hp is under 1, we die
            Debug.Log("You Died!");
    }
}

