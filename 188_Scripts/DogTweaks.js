#pragma strict

var speed:float = 10; // degrees per second
private var curEuler:Vector3;
private var rotating:boolean = false;

function Start(){
  curEuler = transform.eulerAngles;
}

function Update () 
{
	if(Time.timeSinceLevelLoad >= 16 && Time.timeSinceLevelLoad <=17 )
		RotateAngle(10);
}

function RotateAngle(angle: float){
  if (rotating) return; // ignore calls to RotateAngle while rotating
  rotating = true;  // set the flag
  var newAngle = curEuler.y+angle; // calculate the new angle
  while (curEuler.y < newAngle){
    // move a little step at constant speed to the new angle:
    curEuler.y = Mathf.MoveTowards(curEuler.y, newAngle, speed*Time.deltaTime);
    transform.eulerAngles = curEuler; // update the object's rotation...
    yield; // and let Unity free till the next frame
  }
  rotating = false;
}