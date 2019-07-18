using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boardAnimation : MonoBehaviour {

	public Material image1;
	public Material image2;
	public Material image3;

	private MeshRenderer meshRenderer;
	private Material material;

	// Use this for initialization
	void Awake () {

		meshRenderer = GetComponent<MeshRenderer>();
		meshRenderer.material = image1;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Time.fixedTime == 7.0f)
		{
			Debug.Log("7 seconds passed");
			meshRenderer.material = image2;
		}

		if (Time.fixedTime == 15.0f)
		{
			Debug.Log("15 seconds passed");
			meshRenderer.material = image3;
		}
	}
}
