
public var MainCam : Camera ;
public var DogCam : Camera ;
public var ClockCam : Camera ;

function Update() {

	if ((Time.timeSinceLevelLoad >= 0 && Time.timeSinceLevelLoad<= 10))
	{
		MainCam.camera.enabled = false;
		DogCam.camera.enabled = false;
		ClockCam.camera.enabled = true;
	}
	
	if (Time.timeSinceLevelLoad >= 10 && Time.timeSinceLevelLoad<= 16)
	{
		MainCam.camera.enabled = true;
		DogCam.camera.enabled = false;
		ClockCam.camera.enabled = false;
	}
	
	if (Time.timeSinceLevelLoad >= 16 && Time.timeSinceLevelLoad<= 20)
	{
		MainCam.camera.enabled = false;
		DogCam.camera.enabled = true;
		ClockCam.camera.enabled = false;
	}
}