using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRig : MonoBehaviour {

	public GameObject pole, platform; //pole = vertical axis, platoform = horizontal axis
	float  hz, vt;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		hz = Input.GetAxis ("Horizontal");
		vt = Input.GetAxis ("Vertical");

		pole.transform.Rotate (Vector3.up * hz*Time.deltaTime*360);

		platform.transform.Rotate (Vector3.right*-vt*Time.deltaTime*360);

	}
}
