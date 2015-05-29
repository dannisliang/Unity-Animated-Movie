#pragma strict

var level : String = "DogWaittss";
var delay : int = 22;
 
Invoke("Load", delay);
 
function Load() {
    AutoFade.LoadLevel("DogWaittss" ,3,1,Color.black);
}