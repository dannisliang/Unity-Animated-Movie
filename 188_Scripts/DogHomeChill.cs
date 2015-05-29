
using UnityEngine;
using System.Collections;


[AddComponentMenu("ControlDog")]
public class DogHomeChill: MonoBehaviour
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
		animation["sitidle"].layer = 3; animation["sitidle"].wrapMode = WrapMode.Loop;
		
		
	}
	
	void Update()
	{
			animation.Play("sitidle");
	}
}

