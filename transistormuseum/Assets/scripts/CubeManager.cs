﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]	// so that you can set the cubes in the array using the EDITOR IN UNITY
public class CubeManager : MonoBehaviour {

	public UserInteraction userInteraction;
	public GameObject cam;
	public GameObject[] cubes;
	public GameObject[] cubesOrigState;

	[Range(20.0f,200.0f)]
	public float spinSpeed;

	public bool spinCurrentCubeOn = true;

	public readonly float cubesOrigZ = 3.0f;
	public readonly float cubesOrigY = 1.1f;

	// Use this for initialization
	void Start () {
		
		userInteraction = GameObject.Find("GameController").GetComponent<UserInteraction>();
		//cubes = GameObject.FindGameObjectsWithTag("node");	// no longer needed after adding [System.Serializable] to do it manually

		//spinSpeed = 70.0f; // default spin speed is 70.0
		//spinCurrentCubeOn = true;
//		cubesOrigZ = 3.0f;
//		cubesOrigY = 1.1f;

		userInteraction.maxIndex = cubes.Length - 1;	// the max index is set to the number of cubes (items) in the array for switching between them
		// (needed to add -1 because C# Array.Length returns the number of items in the array, but the indexing begins at 0 so the max index OVERFLOWS)

		cubesOrigState = new GameObject[userInteraction.maxIndex];
		cubesOrigState = cubes;

	}

	// Update is called once per frame
	void Update () {

		if(spinCurrentCubeOn){

			cubes[userInteraction.nodeIndex].transform.Rotate(Vector3.up, (Input.mousePosition.x-(Screen.width/2))/Screen.width * spinSpeed * Time.deltaTime);	//HORIZ spinning
			//cubes[userInteraction.nodeIndex].transform.Rotate(Vector3.right, (Input.mousePosition.y-(Screen.height/2)) * spinSpeed * Time.deltaTime);	//VERT spinning
		}
	}	// end of update
		

}
