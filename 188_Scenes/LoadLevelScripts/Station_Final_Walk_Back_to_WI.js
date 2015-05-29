#pragma strict

var level : String = "World_Interaction";
var delay : int = 4;
 
Invoke("Load", delay);
 
function Load() {
    AutoFade.LoadLevel("World_Interaction" ,3,1,Color.black);
}