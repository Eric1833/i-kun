//quote
/*
@Name： Setting
@Describtion：the script part for the Setting
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
using UnityEngine;//call unity
using UnityEngine.SceneManagement;//Call Unity's Scene Management

//lens control
public class Setting : MonoBehaviour
{
//Manage cutscenes    
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
//Play background music
    public void Music() 
    {

    }


}

