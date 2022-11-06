/*
@Name： NPCcollition
@Describtion：the script part for the collition and communicate
@Programmer: Yuyang Fan
@Date: 6 November 2022
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

public class NPCcollition : MonoBehaviour
{

    public GameObject Ehinter; //get the E hinter collition

    public GameObject talkpanel;//Get the content collition
    public GameObject collition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Ehinter.activeSelf && Input.GetKeyDown(KeyCode.E)) //active change the content
        {
            Ehinter.SetActive(false);
            talkpanel.SetActive(true);
        }
        
    }

    public void OnTriggerEnter(Collider collition) 
    {
        Ehinter.SetActive(true);
    }
    public void OnTriggerExit(Collider collition)
    {
        Ehinter.SetActive(false);
        talkpanel.SetActive(false);
    }
}
