/*
@Name： mainmenu
@Describtion：the script part for the main menu
@Programmer: Jiayi Fu, Yuyang Fan, Chen Lu, Zhaoyang Xue, Haoxuan Feng
@Date: 24th September 2022
        virsion 0.0.0 create code and comments  by Jiayi Fu, Yuyang Fan, Chen Lu, Zhaoyang Xue, Haoxuan Feng

Part for function
@Preconditions: None
@Postconditions: None
@Error and exception condition values or types that can occur, and their meanings: None
@Side effects: None
@Invariants: None
@known faults: None
*/




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void PlayGame () // page for  game part 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    public void Setting() //  page for move to setting part
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    public void QuitGame() //  QUITE the Game
        {
        Application.Quit();
        }
}
