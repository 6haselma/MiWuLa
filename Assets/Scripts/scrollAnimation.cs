using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollAnimation : MonoBehaviour {
	//TODO: alle noch reinziehen
	public Material image1;
	public Material image2;
	public Material image3;
	public GameObject scrollMesh;

	private SkinnedMeshRenderer meshRenderer;
	private Animator animator;
	private bool lastTransitionIsRollingUp;
	private bool thisTransitionIsRolledUp;
	private int counter;

	// Use this for initialization
	void Awake () 
	{
		//set material 1 as start material
		meshRenderer = scrollMesh.GetComponent<SkinnedMeshRenderer>();
		meshRenderer.material = image1;
		//set up animator and parameters 
		animator = GetComponent<Animator>();
		animator.enabled = true;
		lastTransitionIsRollingUp = false;
		thisTransitionIsRolledUp = false;
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log(animator.GetCurrentAnimatorStateInfo(0).IsName("RollingUp"));
		if (animator.GetCurrentAnimatorStateInfo(0).IsName("RollingUp"))
		{
			lastTransitionIsRollingUp = true;
		}

		if (animator.GetCurrentAnimatorStateInfo(0).IsName("RolledUp") && lastTransitionIsRollingUp)
		{
			thisTransitionIsRolledUp = true;
		}

		if (lastTransitionIsRollingUp && thisTransitionIsRolledUp)
		{
			counter += 1;
			lastTransitionIsRollingUp = false;
			thisTransitionIsRolledUp = false;

			if (counter == 1)
			{
				Debug.Log("set image 2");
				meshRenderer.material = image2;	
			}
			else if (counter == 2)
			{
				Debug.Log("Set image 3");
				meshRenderer.material = image3;	
			}
			else if (counter == 3)
			{
				animator.enabled = false;
			}
		}



		/* if (animator.GetCurrentAnimatorStateInfo(0).IsName("Armature_001|RolledUp"))
		{

		}*/

	}
}
