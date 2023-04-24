//• The software must be adequately commented with:weather system.
//• Prologue Comments:
//• Name of code artifact: c##, unity
//• Brief description of what the code does:code for make a rain day.
//• Programmer's name:Jiayi Fu
//• Date the code was created:2022/3/18
//• Dates the code was revised:2021/4/1
//• Any known faults: no
//• Postconditions
//• Return values or types, and their meanings
//• Error and exception condition values or types that can occur, and their meanings: no
//• Side effects: no
//• Invariants：no

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//are used to control the intensity of different weather effects in a Unity game.
public class WeatherManage : MonoBehaviour
{
    //The "[SerializeField]" attribute indicates that each of the variables should be serialized, which means they can be edited in the Unity Editor.
    //The "Range(0f, 1f)" attribute specifies a range of values that each variable can take on. In this case, each variable can take on any value between 0 and 1, inclusive.
    //The "RainIntensity" variable is used to control the intensity of rain in the game.
    //The "SnowIntensity" variable is used to control the intensity of snow in the game.
    //The "HailIntensity" variable is used to control the intensity of hail in the game.
    //The "FogIntensity" variable is used to control the intensity of fog in the game.
    [SerializeField, Range(0f, 1f)] float RainIntensity;
    [SerializeField, Range(0f, 1f)] float SnowIntensity;
    [SerializeField, Range(0f, 1f)] float HailIntensity;
    [SerializeField, Range(0f, 1f)] float FogIntensity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
