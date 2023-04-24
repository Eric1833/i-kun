// Name of code artifact: CameraUtility
// Brief description: The script for the Pause Menu
// Programmer's name:Yuyang Fan
// Date the code was created:2022/9/22
// Dates the code was revised:2023/4/23
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

public class PauseMenu : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (stopped == true)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1f;
                stopped = false;
                Menu.SetActive(false);
            }
            else
            {
                pause();
                Cursor.lockState = CursorLockMode.None; // give the mouse access
                Menu.SetActive(true);
            }
        }
    }

    void pause()
    {
        Time.timeScale = 0f; //set the game time -> 0
        stopped = true;
    }

    public void resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        stopped = false;
        Menu.SetActive(false);
    }

    public void restart()
    {
        SceneManager.LoadScene(1);
        resume();
    }

    public void exit()
    {
        /*
        Debug.Log("Quit Application");
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif*/
        SceneManager.LoadScene(0);
    }

}
