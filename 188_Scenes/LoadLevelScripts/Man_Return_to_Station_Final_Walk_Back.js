#pragma strict

var level : String = "Station_Final_Walk_Back";
var delay : int = 14;
 
Invoke("Load", delay);
 
function Load() {
    AutoFade.LoadLevel("Station_Final_Walk_Back" ,3,1,Color.black);
}