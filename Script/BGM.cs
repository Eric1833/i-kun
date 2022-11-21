/*
@Name£º BGM
@Describtion£ºthe script part for the BGM
@Programmer: Chen Lu
@Date: November 20 2022
        virsion 0.0.0 create code and comments  by Yuyang Fan
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

public class BGM : MonoBehaviour
{
    private static BGM instance = null;
    public static BGM Instance
    {
        get { return instance; }
    }
    //load the BGM
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
