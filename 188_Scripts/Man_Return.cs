using UnityEngine;
using System.Collections;

public class Man_Return: MonoBehaviour {
	
	void Start()
	{
		gameObject.SetActive(true);
		Invoke ("appear", 2.0f);
	}
	void appear()
	{
		if(!gameObject.activeInHierarchy)
			gameObject.SetActive(true);
	}

}
