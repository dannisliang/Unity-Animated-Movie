using UnityEngine;
using System.Collections;


public class RotateFixHome : MonoBehaviour {
	
	protected Animator animator;

	
	void Start () 
	{
		animator = GetComponent<Animator>();
	}
	
	void Update () 
	{
		if(animator)
		{
			//get the current state
			AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

			if(stateInfo.nameHash == Animator.StringToHash("Base Layer.Stand to crouch"))
			{
				transform.Rotate (Vector3.up, (float) -0.8, Space.Self);
			}

		}		
	}   		  
}
