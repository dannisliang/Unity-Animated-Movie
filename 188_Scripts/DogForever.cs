
using UnityEngine;
using System.Collections;


[AddComponentMenu("DogForever")]
public class DogForever: MonoBehaviour
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
		animation["walk"].layer = 1; animation["walk"].wrapMode = WrapMode.Once;
		animation["barking"].layer = 3; animation["barking"].wrapMode = WrapMode.Loop;
		animation["scratching"].layer = 3; animation["scratching"].wrapMode = WrapMode.Loop;
		animation["howl"].layer = 3; animation["howl"].wrapMode = WrapMode.Loop;
		animation["walk"].speed = 0.30f;
		
		
	}
	
	void Update()
	{
		if (Time.timeSinceLevelLoad >= 0 &&  Time.timeSinceLevelLoad <= 3)
			animation.Play("scratching");
		if (Time.timeSinceLevelLoad >= 9.5 &&  Time.timeSinceLevelLoad <= 18)
			animation.Play("barking");
		if (Time.timeSinceLevelLoad >= 18 && Time.timeSinceLevelLoad <= 19)
			animation.Play("walk");
		if (Time.timeSinceLevelLoad >= 23)
			animation.Play("howl");
	}
}