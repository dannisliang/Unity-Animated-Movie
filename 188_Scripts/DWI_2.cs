
using UnityEngine;
using System.Collections;


[AddComponentMenu("ControlDog")]
public class DWI_2: MonoBehaviour
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
		animation["beg"].layer = 0; animation["beg"].wrapMode = WrapMode.Once;
	}

	void LateUpdate()
	{
		animation.PlayQueued("beg", QueueMode.CompleteOthers);
	}
}

