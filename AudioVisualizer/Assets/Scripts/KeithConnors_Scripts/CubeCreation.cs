using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CubeCreation : MonoBehaviour 
{

	[SerializeField] private GameObject _cubePrefab;

	//[SerializeField] private ParticleSystem _particle;
	
	GameObject[] CubeArray = new GameObject[512]; 
	public float MaxScale;
	
	// Use this for initialization
	void Start ()
	{
		
		for (int i = 0; i < 512; i++)
		{
			GameObject InstCube = Instantiate(_cubePrefab);	
			InstCube.transform.position = transform.position;
			InstCube.transform.parent = transform;
			InstCube.name = "Cube Instance - " + i;
				transform.eulerAngles = new Vector3(0, -0.703125f * i, 0); //Circular rotation around the parent game object. - -0.703125f
			InstCube.transform.position = Vector3.forward * 150;
			CubeArray[i] = InstCube;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		for (int i = 0; i < 512; i++)
		{
			if (CubeArray != null)
			{
				
				CubeArray[i].transform.localScale = new Vector3(2, Audio._samples[i] * MaxScale, 2);
			}

		//	_particle.Emit(Mathf.Abs((int) Audio._samples[i]));
		}
		//pseudocode
//		 temp = profile.colorGrading.settings.basic.temperature;
//		temp++;
//		profile.colorGrading.settings.basic.temperature = temp;
	}
}