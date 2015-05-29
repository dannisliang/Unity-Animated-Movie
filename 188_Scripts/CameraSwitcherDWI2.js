
public var Camera1 : Camera ;
public var Camera2 : Camera ;

function Update() {

	if ((Time.timeSinceLevelLoad <=3))
	{
		Camera2.camera.enabled = false;
		Camera1.camera.enabled = true;
	}
	
	if ((Time.timeSinceLevelLoad > 3))
	{
		Camera2.camera.enabled = true;
		Camera1.camera.enabled = false;
	}
}