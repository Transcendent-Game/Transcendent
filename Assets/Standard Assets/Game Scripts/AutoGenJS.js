#pragma strict
//Automatically generate stuff on a low-performance level

var invisiWall : GameObject;
var map : Terrain;

function Start () {
GameObject.Instantiate(invisiWall,map.transform.position,invisiWall.transform.rotation);
}

function Update () {

}