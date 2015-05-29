using UnityEngine;
using System.Collections;

public class TrainDogPOV : MonoBehaviour
{
	public float moveSpeed = 10f;
	
	void Update() 
	{
		if (Time.timeSinceLevelLoad >= 5 && Time.timeSinceLevelLoad <= 14.0) 
		{
			transform.Translate(-Vector3.forward * 1.01f );
		}
	}	
}
