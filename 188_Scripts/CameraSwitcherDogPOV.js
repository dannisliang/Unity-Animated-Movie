//Script for switching between cameras within your scene.

//You can place this script on an empty gameobject in your scene,
//just make sure to drag the appropriate camera into it's appropriate
//slot in the inspector.
// You can add more cameras if you like, make sure to add them down below into the "if" conditions
//and add them up top as a public variable.

public
	var NewCam : Camera ;
public var MainCam : Camera ;
public var ThirdCam : Camera;

function Update() {

	if ((Time.timeSinceLevelLoad <=8))
	{
		MainCam.camera.enabled = true;
		NewCam.camera.enabled = false;
		ThirdCam.camera.enabled = false;
	}
	
	if (Time.timeSinceLevelLoad >= 8 && Time.timeSinceLevelLoad<= 10)
	{
		MainCam.camera.enabled = false;
		NewCam.camera.enabled = true;
		ThirdCam.camera.enabled = false;
	}
	
	if (Time.timeSinceLevelLoad>= 10)
	{
		MainCam.camera.enabled = false;
		NewCam.camera.enabled = false;
		ThirdCam.camera.enabled = true;
	}
	
	
	
}