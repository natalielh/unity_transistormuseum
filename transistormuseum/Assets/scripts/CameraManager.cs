using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

	public UserInteraction userInteraction;
	public CubeManager cubeManager;

	public GameObject cam;

	[Range(-1.0f, 1.0f)]
	public float cameraHorizOffset;

	public readonly Vector3 defaultCameraPos = new Vector3(0.0f, 4.25f, -5.0f);
	public readonly Vector3 defaultCameraRot = new Vector3(10.0f, 0.0f, 0.0f);

	public bool camMoveStarted = false;

	public Vector3 newCameraPos = new Vector3(0.0f, 0.0f, 0.0f);
	public Vector3 oldCameraPos = new Vector3(0.0f, 0.0f, 0.0f);

	public bool lookAtIndexOnStart = true;
	public bool instantSnapCam = true;


	// Use this for initialization
	void Start () {
		userInteraction = GameObject.Find("GameController").GetComponent<UserInteraction>();
		cubeManager = GameObject.Find("GameController").GetComponent<CubeManager>();
		cam = GameObject.Find("viewer");

		if (lookAtIndexOnStart) {
			cam.transform.position = new Vector3(
				cubeManager.cubesOrigState [userInteraction.nodeIndex].transform.position.x + cameraHorizOffset,
				defaultCameraPos.y,
				defaultCameraPos.z
			);
		}
		else {
			cam.transform.position = defaultCameraPos;	// when the game is first started, the camera position is set to the default assigned at the top
		}
		cam.transform.rotation = Quaternion.Euler(defaultCameraRot);	// camera rotation is also set to default

//		oldCameraPos = cam.transform.position;
//		newCameraPos = oldCameraPos;




		// (this code is repeated below too)
		// moves the current selected object up to camera
		cubeManager.cubes[userInteraction.nodeIndex].transform.position = new Vector3(
			cubeManager.cubes[userInteraction.nodeIndex].transform.position.x,
			(defaultCameraPos.y - 0.7f),
			(defaultCameraPos.z + 2)	);

	}
	
	// Update is called once per frame
	void Update () {

		if(userInteraction.currentlyMoving){

			if (newCameraPos.x == cam.transform.position.x){	// check the camera's transform live
				userInteraction.currentlyMoving = false;
				camMoveStarted = false;
				Debug.Log("the boolean currentlyMoving was set to: " + userInteraction.currentlyMoving);
			}

			if(!camMoveStarted){
				oldCameraPos = cam.transform.position;	// save a snapshot of the current camera position before any movement takes place
				newCameraPos = new Vector3(
					cubeManager.cubesOrigState[userInteraction.nodeIndex].transform.position.x + cameraHorizOffset,	// get the x-coordinate from the GameObject array of nodes, and add the camera offset
					cam.transform.position.y,
					cam.transform.position.z
				);	// this is the camera position we will be going to



				camMoveStarted = true;	// exit camMoveStarted
			}

			if(camMoveStarted){
				if (instantSnapCam) {
					cam.transform.position = newCameraPos;
					Debug.Log("Camera snapped to: " + newCameraPos);

					//move the node z-value up so we can look at it
					//first move all of them back to default z position
					for(int i=0; i<userInteraction.maxIndex; i++){
						cubeManager.cubes[i].transform.position = new Vector3(
							cubeManager.cubes[i].transform.position.x,
							cubeManager.cubesOrigY,
							cubeManager.cubesOrigZ	);
						//cubeManager.cubes[i].transform.position = cubeManager.cubesOrigState[i].transform.position;
						//cubeManager.cubes[i].transform.position.z = 3;
					}
					//then move the new one up closer to camera
					cubeManager.cubes[userInteraction.nodeIndex].transform.position = new Vector3(
						cubeManager.cubes[userInteraction.nodeIndex].transform.position.x,
						(defaultCameraPos.y - 0.7f),
						(defaultCameraPos.z + 2)	);
					//cubeManager.cubes[userInteraction.nodeIndex].transform.position.z = (defaultCameraPos.z + 2);

				}
				else {
					//cam.transform.position = Vector3.Lerp();
					Debug.Log("Lerping camera...");
				}
			}





		

		}	// end of currentlyMoving check

	}	// end of Update loop

//	void SetUpCameraMovement () {
//		
//		oldCameraPos = cam.transform.position;	// save a snapshot of the current camera position before any movement takes place
//		newCameraPos = new Vector3(
//			cubeManager.cubesOrigState[userInteraction.nodeIndex].transform.position.x,	// get the x-coordinate from the GameObject array of nodes
//			cam.transform.position.y,
//			cam.transform.position.z
//		);
//
//		camMoveStarted = true;
//	}

}
