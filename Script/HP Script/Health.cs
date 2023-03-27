/// <summary>
/// Health.cs
/// Author: MutantGopher
/// This is a sample health script.  If you use a different script for health,
/// make sure that it is called "Health".  If it is not, you may need to edit code
/// referencing the Health component from other scripts
/// </summary>

using UnityEngine;
using System.Collections;


public class Health : MonoBehaviour
{
	public bool canDie = true;					// Whether or not this health can die
	
	public float startingHealth = 100.0f;		// The amount of health to start with
	public float maxHealth = 100.0f;			// The maximum amount of health
	private float currentHealth;				// The current ammount of health

	public bool replaceWhenDead = false;		// Whether or not a dead replacement should be instantiated.  (Useful for breaking/shattering/exploding effects)
	public GameObject deadReplacement;			// The prefab to instantiate when this GameObject dies
	public bool makeExplosion = false;			// Whether or not an explosion prefab should be instantiated
	public GameObject explosion;				// The explosion prefab to be instantiated

	public bool isPlayer = false;				// Whether or not this health is the player
	public GameObject deathCam;					// The camera to activate when the player dies

	private bool dead = false;					// Used to make sure the Die() function isn't called twice
	
	public float RandomPos;


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
		float time = 5.0f;
		Debug.Log("zombie dead");
		// This GameObject is officially dead.  This is used to make sure the Die() function isn't called again
		dead = true;
		
		animator.SetBool("Dead", true);

		// Remove this GameObject from the scene
		//Destroy(gameObject);
		
		Destroy(gameObject, time);

		if(deadReplacement){
			StartCoroutine(waiter());
        }
		
		//StartCoroutine(waiter2());
	}
	IEnumerator waiter()
	{
		yield return new WaitForSeconds(3f);
		float posx = transform.position.x + Random.Range(-RandomPos + 10, RandomPos - 10);//get a random x position 
            
        float posz = transform.position.z + Random.Range(-RandomPos + 10, RandomPos - 10);//get a random z position 

       	Vector3 randomNewPos = new Vector3(posx, transform.position.y, posz);//combo the new position
        Instantiate(deadReplacement, randomNewPos, transform.rotation);
    }

	
	
}
