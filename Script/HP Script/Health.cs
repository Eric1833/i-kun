/*
@Name： Health
@Describtion：the script part for the main menu
@Programmer: Yuyang Fan
@Date: 23 October 2022
        virsion 0.0.0 create code and comments  by Yuyang Fan

Part for function
@Preconditions: None
@Postconditions: None
@Error and exception condition values or types that can occur, and their meanings: None
@Side effects: None
@Invariants: None
@known faults: None
*/

using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{
    public bool canDie = true;                  // Whether or not this health can die

    public float startingHealth = 100.0f;       // The amount of health to start with
    public float maxHealth = 100.0f;            // The maximum amount of health
    private float currentHealth;                // The current ammount of health

    public bool replaceWhenDead = false;        // Whether or not a dead replacement should be instantiated.  (Useful for breaking/shattering/exploding effects)
    public GameObject deadReplacement;          // The prefab to instantiate when this GameObject dies
    public bool makeExplosion = false;          // Whether or not an explosion prefab should be instantiated
    public GameObject explosion;                // The explosion prefab to be instantiated

    public bool isPlayer = false;               // Whether or not this health is the player
    public GameObject deathCam;                 // The camera to activate when the player dies

    private bool dead = false;                  // Used to make sure the Die() function isn't called twice



    // FIXED PART //
    private Animator animator; // got animator



    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();//get animator 

        // Initialize the currentHealth variable to the value specified by the user in startingHealth
        currentHealth = startingHealth;

    }

    public void ChangeHealth(float amount)
    {

        // Change the health by the amount specified in the amount variable
        currentHealth += amount;
        animator.SetBool("hostility", true);
        Debug.Log("changed");
        Debug.Log(currentHealth);
        // If the health runs out, then Die.
        if (currentHealth <= 0)
            Die();

        // Make sure that the health never exceeds the maximum health
        else if (currentHealth > maxHealth)
            currentHealth = maxHealth;
    }

    public void Die()
    {
        Debug.Log("zombie dead");
        // This GameObject is officially dead.  This is used to make sure the Die() function isn't called again
        dead = true;

        animator.SetBool("Dead", true);


        // Remove this GameObject from the scene
        //Destroy(gameObject);
    }
}
