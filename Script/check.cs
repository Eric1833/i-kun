//• The software must be adequately commented with:make player trasn to different place.
//• Prologue Comments:
//• Name of code artifact: c##, unity
//• Brief description of what the code does:code for make a portal.
//• Programmer's name:Jiayi Fu
//• Date the code was created:2022/2/30
//• Dates the code was revised:2022/4/1
//• Any known faults: no
//• Postconditions
//• Return values or types, and their meanings
//• Error and exception condition values or types that can occur, and their meanings: Can't trigger teleportation
//• Side effects: no
//• Invariants：no


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    void Update()
    {

        //Portal p is used to teleport
        if (Input.GetKeyDown(KeyCode.P)) //active change the content
        {


            transform.position = new Vector3(-196, 101, 15);// move to this location 
        }
    }
}
