//• The software must be adequately commented with:setting page have soame function on it.
//• Prologue Comments:
//• Name of code artifact: c##, unity
//• Brief description of what the code does:code for jump back.
//• Programmer's name:Jiayi Fu
//• Date the code was created:2021/9/25
//• Dates the code was revised:2021/10/30
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


public class Setting : MonoBehaviour
{   
    
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);//This code is written in C# programming language and appears to be implementing a function called "Back()" for returning to the previous scene.
    }

    public void Music() 
    {

    }


}

