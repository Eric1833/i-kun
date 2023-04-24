// Name of code artifact: Health Bar
// Brief description: The script for Health Bar control
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
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public HealthChar playerHealth;

    private void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthChar>();
        healthBar = GetComponent<Slider>();
        healthBar.maxValue = playerHealth.maxHealth;
        healthBar.value = playerHealth.maxHealth;
    }

    public void SetHealth(int hp)
    {
        healthBar.value = hp;
    }
}
