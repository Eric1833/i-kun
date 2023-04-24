// Name of code artifact: Health character
// Brief description: The script for the character HP recording
// Programmer's name: Chen Lu
// Date the code was created:11/22/2022
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
using UnityEngine.SceneManagement;

public class HealthChar : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;

    public HealthBar healthBar;
    public GameObject Menu;
    void Start()
    {
        curHealth = maxHealth;
    }

    void Update()
    {
        if( Input.GetKeyDown( KeyCode.Q ) )
        {
            DamagePlayer(10);
        }
        if (curHealth <= 0)
        {   
            Cursor.lockState = CursorLockMode.None;
            Menu.SetActive(true);
        }
    }

    public void DamagePlayer( int damage )
    {
        curHealth -= damage;

        healthBar.SetHealth( curHealth );
    }

    public void HealPlayer( int damage )
    {   
        if(curHealth <100)
        {
        curHealth += damage;

        healthBar.SetHealth( curHealth );
        }
    }
    void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "Zombie") {
        // Handle collision with zombie
    }
    }
}