//Script for switching between cameras within your scene.

//You can place this script on an empty gameobject in your scene,
//just make sure to drag the appropriate camera into it's appropriate
//slot in the inspector.
// You can add more cameras if you like, make sure to add them down below into the "if" conditions
//and add them up top as a public variable.

public 	var Camera1 : Camera ;
public var Camera2 : Camera ;
public var Camera3 : Camera ;

function Update() {

	if ((Time.timeSinceLevelLoad >= 0 && Time.timeSinceLevelLoad<= 5))
	{
		Camera1.camera.enabled = true;
		Camera2.camera.enabled = false;
		Camera3.camera.enabled = false;
	}
	
	if (Time.timeSinceLevelLoad >= 5 && Time.timeSinceLevelLoad<= 6)
	{
		Camera1.camera.enabled = false;
		Camera2.camera.enabled = true;
		Camera3.camera.enabled = false;
	}
	
	if (Time.timeSinceLevelLoad >= 6 && Time.timeSinceLevelLoad<= 8)
	{
		Camera3.camera.enabled = true;
		Camera1.camera.enabled = false;
		Camera2.camera.enabled = false;
	}
	
	
}