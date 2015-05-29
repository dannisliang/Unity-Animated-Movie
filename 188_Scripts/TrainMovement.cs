using UnityEngine;
using System.Collections;

public class TrainMovement : MonoBehaviour
{
	public float moveSpeed = 1.1f;

	void Update() 
	{
		if (Time.timeSinceLevelLoad >= 4 && Time.timeSinceLevelLoad <= 8) 
		{
			transform.Translate(-Vector3.forward * 1.3f );
		}

		if (Time.timeSinceLevelLoad >= 21 && Time.timeSinceLevelLoad <= 28) 
		{
			transform.Translate(Vector3.forward * 1.9f);
		}
	}	
}
