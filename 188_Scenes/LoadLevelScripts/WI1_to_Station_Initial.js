#pragma strict

var level : String = "Station_Initial_Blend";
var delay : int = 7;
 
Invoke("Load", delay);
 
function Load() {
    AutoFade.LoadLevel("Station_Initial_Blend" ,3,1,Color.black);
}