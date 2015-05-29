using UnityEngine;
using System.Collections;


[AddComponentMenu("ControlDog")]
public class Dog_Final_Walk_Back: MonoBehaviour
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
	}
	
	void Update()
	{
		animation.Play("trot");	
		transform.Translate(Vector3.forward * Time.deltaTime);
	}
}