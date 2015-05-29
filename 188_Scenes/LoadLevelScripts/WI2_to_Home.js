#pragma strict

var level : String = "Home";
var delay : int = 5;
 
Invoke("Load", delay);
 
function Load() {
    AutoFade.LoadLevel("Home" ,3,1,Color.black);
}