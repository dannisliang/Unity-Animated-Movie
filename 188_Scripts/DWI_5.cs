
using UnityEngine;
using System.Collections;


[AddComponentMenu("ControlDog")]
public class DWI_5: MonoBehaviour
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
		animation["scratching"].layer = 0; animation["scratching"].wrapMode = WrapMode.Once;
	}

	void LateUpdate()
	{
		animation.PlayQueued("scratching", QueueMode.CompleteOthers);
	}
}

