//quote
using System.Collections;   
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

