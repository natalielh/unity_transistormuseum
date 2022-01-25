using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInteraction : MonoBehaviour {

    public CameraManager cameraManager;

    public int minIndex = 0;
	public int maxIndex = 10;	// default: 10 (overridden when the game starts to the cubes array length)

	public int nodeIndex = 0;
	public int lastIndex = 0;

	public bool inputEnabled;
	public bool displayDebugText;

	public bool currentlyMoving;

	// Use this for initialization
	void Start () {

		inputEnabled = true;
		displayDebugText = true;

		currentlyMoving = false;
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.anyKeyDown && inputEnabled){
			if(nodeIndex < maxIndex && ((Input.GetAxisRaw("Horizontal") > 0) || (Input.GetAxisRaw("Vertical") > 0))){
				// if you press RIGHT or UP
				// move the current viewed object index right
				nodeIndex++;
				Debug.Log("The node index was INcremented(+) | nodeIndex = " + nodeIndex);
				currentlyMoving = true;
				Debug.Log("currentlyMoving set to: " + currentlyMoving);
                cameraManager.MoveObjects();
			}
			else if(nodeIndex > minIndex && ((Input.GetAxisRaw("Horizontal") < 0) || (Input.GetAxisRaw("Vertical") < 0))){
				// if you press LEFT or DOWN
				// move the current viewed object index left
				nodeIndex--;
				Debug.Log("The node index was DEcremented(-) | nodeIndex = " + nodeIndex);
				currentlyMoving = true;
				Debug.Log("currentlyMoving set to: " + currentlyMoving);
                cameraManager.MoveObjects();
            }

//			if(nodeIndex < minIndex){
//				nodeIndex = minIndex;
//				Debug.Log("The node index was lowered below bottom threshold, it was reset to 0 | nodeIndex = " + nodeIndex);
//			}

			if(Input.GetKeyDown(KeyCode.F)) {
				displayDebugText = !displayDebugText;	// reverses the boolean
			}

			if (Input.GetKeyDown(KeyCode.Escape)) {
				// press ESC to quit the application
				Debug.Log("ESC key detected, quitting application...");
				Application.Quit();
			}
		}	// end of logic for checking input




	} // end of update loop
}
