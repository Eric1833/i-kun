// Name of code artifact: NPCcollitions
// Brief description: used to check trigger of collition
// Programmer's name:Yuyang Fan
// Date the code was created:2022/9/11
// Dates the code was revised:2023/3/23
// Any known faults: no
// Postconditions:no
// Return values or types, and their meanings:none
// Error and exception condition values or types that can occur, and their meanings: no
// Side effects: no
// Invariants：no
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
