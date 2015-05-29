#pragma strict

var level : String = "Army";
var delay : int = 6;
 
Invoke("Load", delay);
 
function Load() {
    AutoFade.LoadLevel("Army" ,3,1,Color.black);
}