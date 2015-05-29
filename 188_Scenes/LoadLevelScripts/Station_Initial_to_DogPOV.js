#pragma strict

var level : String = "DogPOV";
var delay : int = 22;
 
Invoke("Load", delay);
 
function Load() {
    AutoFade.LoadLevel("DogPOV" ,3,1,Color.black);
}