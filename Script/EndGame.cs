// Name of code artifact: CameraUtility
// Brief description: The script for the End Game Script
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
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject Menu; //get the game menu
    public GameObject Score;
    public bool stopped = false; //check if gane stopped


    // Start is called before the first frame update
    void Start()
    {
        Score.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeScore.Num()> 1000)
        {
            pause2();
            Cursor.lockState = CursorLockMode.None; // give the mouse access
            Menu.SetActive(true);
        }
    }

    void pause2()
    {
        Time.timeScale = 0f; //set the game time -> 0
        stopped = false;
    }

    public void resume2()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        stopped = false;
        Menu.SetActive(false);
    }

    public void restart2()
    {
        SceneManager.LoadScene(1);
        resume2();
    }

    public void exit()
    {
        /*
        Debug.Log("Quit Application");
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
        */
        SceneManager.LoadScene(0);
    }

}
