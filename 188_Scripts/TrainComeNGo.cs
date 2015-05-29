using UnityEngine;
using System.Collections;

public class TrainComeNGo : MonoBehaviour
{
	public float moveSpeed = 1.5f;
	
	void Update() 
	{
		if (Time.timeSinceLevelLoad >= 7 && Time.timeSinceLevelLoad <= 18) 
		{
			transform.Translate(-Vector3.forward * 1.01f );
		}
		
		if (Time.timeSinceLevelLoad >= 23 && Time.timeSinceLevelLoad <= 28) 
		{
			transform.Translate(Vector3.forward * 1.9f);
		}
	}	
}
