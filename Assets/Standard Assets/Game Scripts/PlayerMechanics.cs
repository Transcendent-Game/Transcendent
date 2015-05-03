using UnityEngine;
using System.Collections;
//Controls functions of the game, interactions, and elements that simulate
//RTS game styles

public class PlayerMechanics : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Automatically detects what the player has collided with
	void OnTriggerEnter (Collider info) {
		//LAPTOP detection
		if (info.name.StartsWith ("Laptop")) {
			DoSomething(0);
				}
		//MAIN BASE detection
		else if (info.name.StartsWith ("Main Base")) {
			DoSomething(1);
		}
		//HOUSE detection
		else if (info.name.StartsWith ("House")) {
			DoSomething(2);
		}
		//BLACKSMITH detection
		else if (info.name.StartsWith ("Blacksmith")) {
			DoSomething(3);
		}
		//Detect NOTHING
		else {
			DoSomething(-1);
		}
	}

	//Controles what should happen with certain collisions
	void DoSomething (int itemID) {
		if (itemID == -1) {//Do Nothing
			//Clear...
				}

		if (itemID == 0) {//LAPTOP
			print ("Access your LapeTape Computer");
				}
		if (itemID == 1) {//MAIN BASE
			//?
		}
		if (itemID == 2) {//HOUSE
			print ("Enter Home (Hotkey: E)");
		}
		if (itemID == 3) {//BLACKSMITH
			print ("Enter Blacksmith (Hotkey: E)");
		}
	}
}
