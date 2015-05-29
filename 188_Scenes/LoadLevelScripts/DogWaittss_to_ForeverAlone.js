#pragma strict

var level : String = "ForeverAlone";
var delay : int = 30;
 
Invoke("Load", delay);
 
function Load() {
    AutoFade.LoadLevel("ForeverAlone" ,3,1,Color.black);
}