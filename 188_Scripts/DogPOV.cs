
using UnityEngine;
using System.Collections;


[AddComponentMenu("ControlDog")]
public class DogPOV: MonoBehaviour
{
	public float turningSpeed = 90f;
	public RootMotionComputer computer;
	
	void Start()
	{
		// validate component references
		if (computer == null) computer = GetComponent(typeof(RootMotionComputer)) as RootMotionComputer;
		
		// tell the computer that this script will manage its execution
		computer.isManagedExternally = true;
		// initialize the computer
		computer.Initialize();
		
		// set up properties for the animations
		animation["trot"].layer = 1; animation["trot"].wrapMode = WrapMode.Once;
		animation["barking"].layer = 3; animation["barking"].wrapMode = WrapMode.Loop;
		animation["trot"].speed = 0.60f;
		animation["scratching"].layer = 3; animation["scratching"].wrapMode = WrapMode.Loop;
		
		
	}
	
	void Update()
	{
		if (Time.timeSinceLevelLoad >= 0 &&  Time.timeSinceLevelLoad <= 7)
			animation.Play("scratching");
		if (Time.timeSinceLevelLoad >= 8 &&  Time.timeSinceLevelLoad <= 12)
			animation.Play("barking");
//		if (Time.time >= 8 &&  Time.time <= 9)
//			transform.Rotate (Vector3.up, (float)0.46, Space.Self);
		if (Time.timeSinceLevelLoad >= 12 &&  Time.timeSinceLevelLoad <= 13)
			animation.Play("trot");

	}
}
