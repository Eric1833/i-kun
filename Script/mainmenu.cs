//• The software must be adequately commented with:mainmenu jump to different scene.
//• Prologue Comments:
//• Name of code artifact: c##, unity
//• Brief description of what the code does:code for jump to setting play game and quitgume.
//• Programmer's name:Jiayi Fu
//• Date the code was created:2021/9/25
//• Dates the code was revised:2021/10/23
//• Any known faults: no
//• Postconditions
//• Return values or types, and their meanings
//• Error and exception condition values or types that can occur, and their meanings: no
//• Side effects: no
//• Invariants：no


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void PlayGame ()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//PlayGame(): This function is responsible for loading the next scene in the build index using the Unity SceneManager class.
    }
    public void Setting()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);//This function is responsible for loading the setting scene of the game. It calls SceneManager.
    }
    public void QuitGame()
        {
        Application.Quit();//This function is responsible for quitting the application when called. It uses the Application.Quit() method to close the application.
    }
}
