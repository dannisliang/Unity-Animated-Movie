#pragma strict

var level : String = "World_Interaction 2";
var delay : int = 2;
 
Invoke("Load", delay);
 
function Load() {
    AutoFade.LoadLevel("World_Interaction 2" ,3,1,Color.black);
}