
using UnityEngine;
using System.Collections;


[AddComponentMenu("DogForeverAlone")]
public class DogForeverAlone: MonoBehaviour
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
		
		animation["howl"].layer = 0; 
		animation ["howl"].wrapMode = WrapMode.Loop;
		
		
	}
	
	void Update()
	{
		animation.Play("howl");
	}
}

