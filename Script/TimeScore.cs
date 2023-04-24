// Name of code artifact: CameraUtility
// Brief description: The script for the Time Score recording
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
using UnityEngine.UI;

public class TimeScore : MonoBehaviour
{

    public Text Score;
    public static int IntScore;

    // Start is called before the first frame update
    void Start()
    {
        Score.text = "0";
        IntScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = IntScore.ToString();

    }

    public static void AddScore (int value)
    {
        IntScore += value;
    }
    public static int Num()
    {   
        int score = IntScore;
        return score;
    }

}
