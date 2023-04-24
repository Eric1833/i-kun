// Name of code artifact: CameraUtility
// Brief description: The script for Zombie's control
// Programmer's name:Yuyang Fan, Chen Lu
// Date the code was created:09/22/2022
// Dates the code was revised:04/23/2023
// Any known faults: no
// Postconditions:no
// Return values or types, and their meanings:none
// Error and exception condition values or types that can occur, and their meanings: no
// Side effects: no
// Invariants：no
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Zombie : MonoBehaviour {



    private Transform player;
    public float attackDistance = 5;// attack  distance 
    private Animator animator; // got animator
    public float speed;
    private CharacterController cc;
    public float attackTime = 3;   //set attack speed
    private float attackCounter = 0; //acount attack num
    private bool hostility = false;

    public int zombiescore = 5;
    private int socrecounter = 0;
    private bool att;
    

    void Start () 
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; //get player object
        cc = this.GetComponent<CharacterController>();
        animator = this.GetComponent<Animator>();//get animator 
        attackCounter = attackTime;//set attack speed = time
        
        
    }
    void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "Player") {
        // Handle collision with player
        if(att)
        {
            HealthChar playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthChar>();
            // Call the DamagePlayer function on the playerHealth object with a damage value of 2
            playerHealth.DamagePlayer(2);
        }
    }
}
        

    // Update is called once per frame

    void Update () 
    {
        if(animator.GetBool("hostility"))
        {
            hostility = true; // check if zombie got damage
        }
        if (animator.GetBool("Dead"))
        {
            if(socrecounter == 0)
            {
                TimeScore.AddScore(zombiescore);
                Debug.Log("zombie dead");
                socrecounter ++;
                HealthChar playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthChar>();
                playerHealth.HealPlayer(1);
                
            }
            //animator.SetBool("Dead", true); // zombie die
        }
        else
        {   
            //Debug.Log(TimeScore.Num());
            int checkScore = TimeScore.Num();
            if(checkScore > 10 && checkScore < 50)
            {
                speed = 5;
            }
            if(checkScore > 50 && checkScore < 100)
            {
                speed = 6;
            }
            if(checkScore > 100 && checkScore < 200)
            {
                speed = 7;
            }
            if(checkScore > 200 && checkScore < 300)
            {
                speed = 9;
            }
            if(checkScore > 500 && checkScore < 1000)
            {
                speed = 15;
            }

            Vector3 targetPos =player.position;
            targetPos.y = transform.position.y; //give the y xias to the target
            float distance = Vector3.Distance(targetPos,transform.position); // get distance between zombie and player

            if (distance <= attackDistance +7 || hostility == true) // if zombie can watch you and didnt have hostility
            {
                hostility = true ;
                transform.LookAt(targetPos);// zombie transfer to you
                attackCounter += Time.deltaTime; // attack time ++

                if (distance <= attackDistance) // if zombie can attack
                {
                    if (attackCounter > attackTime)//timer
                    {
                        animator.SetBool("Attack2", true);
                        animator.SetTrigger("Attack");
                        attackCounter = 0;
                        att = true;
                        if(attackCounter == 0){
                        HealthChar playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthChar>();
                        // Call the DamagePlayer function on the playerHealth object with a damage value of 10
                        playerHealth.DamagePlayer(2);
                        }
                    }

                    else
                    {
                        animator.SetBool("Walk", false);
                    }
                }

                else
                {

                    transform.LookAt(targetPos);// zombie transfer to you
                    animator.SetBool("Attack2", false);
                    attackCounter = attackTime;

                    if(animator.GetCurrentAnimatorStateInfo(0).IsName("EnimyWalk"))//if name of anime is " "

                    cc.SimpleMove(transform.forward*speed);
                
                    animator.SetBool("Walk",true);
                }

            }


        }



    }

}