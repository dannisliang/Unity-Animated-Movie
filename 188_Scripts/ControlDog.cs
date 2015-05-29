
using UnityEngine;
using System.Collections;

public class ControlDog: MonoBehaviour
{
	
	void Start()
	{

	}

	void Update()
	{
		if (Time.timeSinceLevelLoad >= 4 && Time.timeSinceLevelLoad <= 5) 
		{
			transform.Rotate (Vector3.up, (float)2.90, Space.Self);
		}
	}
}

