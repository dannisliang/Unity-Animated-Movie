#pragma strict

var level : String = "Man_Return";
var delay : int = 14;
 
Invoke("Load", delay);
 
function Load() {
    AutoFade.LoadLevel("Man_Return" ,3,1,Color.black);
}