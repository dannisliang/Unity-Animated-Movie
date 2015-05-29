using UnityEngine;
using System.Collections;

public class Man_Deactivate: MonoBehaviour {
	
	void Start()
	{
	}
	
	void Update()
	{
		if (Time.timeSinceLevelLoad >= 26 ) 
		{
			gameObject.SetActive(false);
		}
	}
	
}

