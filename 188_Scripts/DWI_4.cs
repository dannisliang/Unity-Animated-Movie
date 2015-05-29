
using UnityEngine;
using System.Collections;


[AddComponentMenu("ControlDog")]
public class DWI_4: MonoBehaviour
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

		animation["sitidle"].layer = 0; animation["sitidle"].wrapMode = WrapMode.Once;

	}

	void LateUpdate()
	{
		animation.PlayQueued("sitidle", QueueMode.CompleteOthers);
	}
}

