
using UnityEngine;
using System.Collections;


[AddComponentMenu("DogShock")]
public class DogShock: MonoBehaviour
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

		animation["beg"].layer = 3; animation["beg"].wrapMode = WrapMode.Loop;
		animation["beg"].speed = 0.8f;
		animation["walk"].speed = 1.00f;
		
		
	}
	
	void Update()
	{
		animation.Play("beg");
	}
}

