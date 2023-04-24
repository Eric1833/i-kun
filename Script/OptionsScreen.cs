//• The software must be adequately commented with:setting page have soame function on it.
//• Prologue Comments:
//• Name of code artifact: c##, unity
//• Brief description of what the code does:code for make a different function in the game which is chage size , sound , etc.
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
using UnityEngine.UI;
using TMPro;

public class OptionsScreen : MonoBehaviour
{

    public Toggle fullscreenTog, vsyncTog;
    public List<ResItem> resolutions = new List<ResItem>();
    private int selectedResolution;
    

    public TMP_Text resolutionLabel;

    // Start is called before the first frame update
    
    void Start()// his code appears to be setting up the initial values for the game's graphics settings, particularly for fullscreen mode, v-sync, and screen resolution. 
    {
        fullscreenTog.isOn = Screen.fullScreen; 
        if (QualitySettings.vSyncCount == 0)// sets the initial state of the "fullscreenTog" toggle component to the current fullscreen state of the game's display using the Screen.fullScreen property.
        {
            vsyncTog.isOn = false;
        }
        else //The next block of code checks the v-sync count of the game's quality settings. 
        {
            vsyncTog.isOn = true;
        }

        bool foundRes = false;
        for (int i = 0; i < resolutions.Count; i++)//The final block of code checks the screen resolution to see if it matches any of the resolutions in a list of supported resolutions
        {
            if (Screen.width == resolutions[i].horizontal && Screen.height == resolutions[i].vertical)//
            {
                foundRes = true;

                selectedResolution = i;

                UpdateReslabel();
            }
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function that is used to decrease the screen resolution in a Unity game.
    public void Resleft()
    {
        selectedResolution--;
        if (selectedResolution < 0)
        {
            selectedResolution = 0;
        }
        UpdateReslabel();

    }
    //function that is used to decrease the screen resolution in a Unity game.
    public void Resright()
    {
        selectedResolution++;
        if (selectedResolution > resolutions.Count -1)
        {
            selectedResolution = resolutions.Count - 1 ;
        }
        UpdateReslabel();
    }
    //pdating a label or UI element that displays the current screen resolution of a Unity game. 
    public void UpdateReslabel()
    { 
        resolutionLabel.text = resolutions[selectedResolution].horizontal.ToString() + " X " + resolutions[selectedResolution].vertical.ToString();
    }
    // is used to update the graphics settings of a Unity game. Specifically, this code updates the v-sync setting and screen resolution based on the values of toggle components in the game's UI.
    public void ApplyGraphics()
    {
        // "vsyncTog" toggle component is on or off. If it's on, then v-sync is enabled by setting the "vSyncCount" property of the "QualitySettings" class to 1. If it's off, then v-sync is disabled by setting the "vSyncCount" property to 0.
        if (vsyncTog.isOn)
        {
            QualitySettings.vSyncCount = 1;
        }
        else 
        {
            QualitySettings.vSyncCount = 0;
        }
         Screen.SetResolution(resolutions[selectedResolution].horizontal, resolutions[selectedResolution].vertical, fullscreenTog.isOn);// uses the "Screen.SetResolution()" method to set the game's screen resolution. It takes three arguments: the horizontal and vertical resolution values of the currently selected resolution from the "resolutions" list, and the boolean value of the "fullscreenTog" toggle component 
    }
}
[System.Serializable]
public class ResItem
{
    public int horizontal, vertical;

}
