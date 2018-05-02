using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
	public GameObject LookAtTarget; //Set within the inspector 

	public float RotationSpeed; //Set within the inspector
	
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (LookAtTarget != null) //Look At Target isn't Null 
		{
			transform.LookAt(LookAtTarget.transform); // Look at the transform of the component within the target field
			transform.RotateAround(LookAtTarget.transform.position, Vector3.up, Time.deltaTime * RotationSpeed); //Rotate around the transform

			if (Input.GetKeyDown(KeyCode.LeftArrow))
			{
				transform.RotateAround(LookAtTarget.transform.position, Vector3.up, Time.deltaTime * RotationSpeed);
			}

			if (Input.GetKeyDown(KeyCode.RightArrow))
			{
				transform.RotateAround(LookAtTarget.transform.position, Vector3.down, Time.deltaTime * RotationSpeed);
			}
			
			
//			if (Input.GetButton("Horizontal"))
//			{
//				transform.RotateAround(LookAtTarget.transform.position, Vector3.up, Time.deltaTime * RotationSpeed);
//			}
//
//			if (Input.GetButton("Vertical"))
//			{
//				transform.RotateAround(LookAtTarget.transform.position, Vector3.down, Time.deltaTime * RotationSpeed);
//			}
		}
	}
}
