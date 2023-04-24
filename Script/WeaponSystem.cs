// This script manages weapon switching.  It's recommended that you attach this to a parent GameObject of all your weapons, but this is not necessary.
// This script allows the player to switch weapons in two ways, by pressing the numbers corresponding to each weapon, or by scrolling with the mouse.

// Name of code artifact: First Person Controller
// Brief description: The script for the first person controller movement Script
// Programmer's name: Chen Lu, Yuyang Fan, Jiayi Fu, Zhaoyang Xue, Haoxuan Feng
// Date the code was created:09/22/2022
// Dates the code was revised:04/23/2023
// Any known faults: no
// Postconditions:no
// Return values or types, and their meanings:none
// Error and exception condition values or types that can occur, and their meanings: no
// Side effects: no
// Invariants：no
using UnityEngine;
using System.Collections;

public class WeaponSystem : MonoBehaviour
{
	public GameObject[] weapons;				// The array that holds all the weapons that the player has
	public int startingWeaponIndex = 0;			// The weapon index that the player will start with
	private int weaponIndex;					// The current index of the active weapon


	// Use this for initialization
	void Start()
	{
		// Make sure the starting active weapon is the one selected by the user in startingWeaponIndex
		weaponIndex = startingWeaponIndex;
		SetActiveWeapon(weaponIndex);
	}
	
	// Update is called once per frame
	void Update()
	{
		// Allow the user to instantly switch to any weapon
		int checkScore = TimeScore.Num();
		if (Input.GetButtonDown("Weapon 1"))
			SetActiveWeapon(0);
		if (Input.GetButtonDown("Weapon 2"))
			if(checkScore >=20)
				SetActiveWeapon(1);
		if (Input.GetButtonDown("Weapon 3"))
			if(checkScore >=40)
				SetActiveWeapon(2);
		if (Input.GetButtonDown("Weapon 4"))
			if(checkScore >=80)
				SetActiveWeapon(3);
		if (Input.GetButtonDown("Weapon 5"))
			if(checkScore >=100)
				SetActiveWeapon(4);
		if (Input.GetButtonDown("Weapon 6"))
			if(checkScore >=150)
				SetActiveWeapon(5);
		if (Input.GetButtonDown("Weapon 7"))
			if(checkScore >=200)
				SetActiveWeapon(6);
		if (Input.GetButtonDown("Weapon 8"))
			if(checkScore >=250)
				SetActiveWeapon(7);
		//if (Input.GetButtonDown("Weapon 9"))
			//SetActiveWeapon(8);
		/*
		// Allow the user to scroll through the weapons
		if (Input.GetAxis("Mouse ScrollWheel") > 0)
			NextWeapon();
		if (Input.GetAxis("Mouse ScrollWheel") < 0)
			PreviousWeapon();
		*/
	}

	void OnGUI()
	{


	}

	public void SetActiveWeapon(int index)
	{
		// Make sure this weapon exists before trying to switch to it
		if (index >= weapons.Length || index < 0)
		{
			Debug.LogWarning("Tried to switch to a weapon that does not exist.  Make sure you have all the correct weapons in your weapons array.");
			return;
		}

		// Send a messsage so that users can do other actions whenever this happens
		SendMessageUpwards("OnEasyWeaponsSwitch", SendMessageOptions.DontRequireReceiver);

		// Make sure the weaponIndex references the correct weapon
		weaponIndex = index;

		// Make sure beam game objects aren't left over after weapon switching
		weapons[index].GetComponent<Weapon>().StopBeam();

		// Start be deactivating all weapons
		for (int i = 0; i < weapons.Length; i++)
		{
			weapons[i].SetActive(false);
		}

		// Activate the one weapon that we want
		weapons[index].SetActive(true);
	}

	public void NextWeapon()
	{
		weaponIndex++;
		if (weaponIndex > weapons.Length - 1)
			weaponIndex = 0;
		SetActiveWeapon(weaponIndex);
	}

	public void PreviousWeapon()
	{
		weaponIndex--;
		if (weaponIndex < 0)
			weaponIndex = weapons.Length - 1;
		SetActiveWeapon(weaponIndex);
	}
}
