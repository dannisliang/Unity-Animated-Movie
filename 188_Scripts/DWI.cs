
using UnityEngine;
using System.Collections;


[AddComponentMenu("ControlDog")]
public class DWI: MonoBehaviour
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

		animation["trot"].layer = 0; animation["trot"].wrapMode = WrapMode.Once;
		animation["trot"].speed = 0.1f;
	}

	void LateUpdate()
	{
		animation.PlayQueued("trot", QueueMode.CompleteOthers);	
	}
}

