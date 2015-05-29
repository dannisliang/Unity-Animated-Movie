#pragma strict

var level : String = "Home_Shock";
var delay : int = 9;
 
Invoke("Load", delay);
 
function Load() {
    AutoFade.LoadLevel("Home_Shock" ,3,1,Color.black);
}