//• The software must be adequately commented with:keep BGM play in different screen.
//• Prologue Comments:
//• Name of code artifact: c##, unity
//• Brief description of what the code does:code for keep BGM continuous play.
//• Programmer's name:Jiayi Fu
//• Date the code was created:2021/10/23
//• Dates the code was revised:2022/3/16
//• Any known faults: no
//• Postconditions
//• Return values or types, and their meanings
//• Error and exception condition values or types that can occur, and their meanings
//• Side effects
//• Invariants


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    private static BGM instance= null;
    public static BGM Instance
    {
        get { return instance; }
    }
    //The first line checks if an instance of GameObject has already been created and is not equal to the current instance.
    //If there is no existing instance or if the existing instance is the same as the current instance, the code sets the instance variable to the current instance.
    //The last line sets the current instance not to be destroyed when a new scene is loaded using the DontDestroyOnLoad() method.
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject); 
            return;
        }
        else
        {
            instance = this;//If there is no existing instance or if the existing instance is the same as the current instance, the code sets the instance variable to the current instance.
        }
        DontDestroyOnLoad(this.gameObject);//The last line sets the current instance not to be destroyed when a new scene is loaded using the DontDestroyOnLoad() method.
    }
}
