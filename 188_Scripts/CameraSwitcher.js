//Script for switching between cameras within your scene.

//You can place this script on an empty gameobject in your scene,
//just make sure to drag the appropriate camera into it's appropriate
//slot in the inspector.
// You can add more cameras if you like, make sure to add them down below into the "if" conditions
//and add them up top as a public variable.

public
	var NewCam : Camera ;
public var MainCam : Camera ;
public var StillCam : Camera ;

function Update() {

	if ((Time.timeSinceLevelLoad >= 19) && (Time.timeSinceLevelLoad <=23))
	{
		MainCam.camera.enabled = false;
		NewCam.camera.enabled = false;
		StillCam.camera.enabled = true;
	}
	
	if (Time.timeSinceLevelLoad <= 19)
	{
		MainCam.camera.enabled = true;
		NewCam.camera.enabled = false;
		StillCam.camera.enabled = false;
	}
	
	if (Time.timeSinceLevelLoad >=26)
	{
		MainCam.camera.enabled = false;
		NewCam.camera.enabled = true;
		StillCam.camera.enabled = false;
	}
}