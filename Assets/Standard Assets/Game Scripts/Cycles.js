#pragma strict
//BETA - Cycles manages the time of day/brightness to the game
//Helps simulate day and night, to make it more intense to play
var sun : Light; //Source of light to change
var TOD : int; //Time of Day in whole values 12-hour
var itterationSpeed : int = 60; //How fast in seconds one minute passes
var holdTime : boolean = false; //Should the time stay at the same hour?

private var i : int;//Represent itterationSpeed as a watched value
function Start () {
TOD = -400;//5 O'clock PM
}

function Update () {
if(holdTime == false){
i++;
	if(i == itterationSpeed){
TOD++;
i = 0;
		}
		sun.transform.eulerAngles = Vector3(30 ,TOD / 1 * 0.20, 0);
		if(TOD > 250){
TOD = -1000;
}
	}
}