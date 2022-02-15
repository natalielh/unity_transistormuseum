using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //need to import UnityEngine.UI to control the text displayed on the GUI

public class DebugText : MonoBehaviour {

	public UserInteraction userInteraction;
	Text screenText;
//
//	public string indexMessageString;

	// Use this for initialization
	void Start () {
		userInteraction = GameObject.Find("GameController").GetComponent<UserInteraction>();
		screenText = GetComponent<Text>();
        //screenText.enabled = false;

//		indexMessageString =
//			"PRESS F TO SHOW/HIDE THIS TEXT \n" +
//			"CURRENT DISPLAY INDEX: "
//		;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown)
        {
			
//			screenText.text = indexMessageString + "[" + userInteraction.nodeIndex + "]";
			screenText.text =
				// \n puts 'enter' in the string
				"*PRESS F TO SHOW/HIDE THIS TEXT \n" +
				"CREATED BY: [VIVIAN FU, ERIKA DAVIS, and NATALIE LE HUENEN] \n" +
				"[THE TRANSISTOR MUSEUM]  \n" +
				"VERSION: 2.0 \n" +
				"APPLICATION RUNNING ON: [" + Application.platform + "] \n" +
				"SCREEN RESOLUTION: [" + Screen.currentResolution + "] \n" +
				"NUMBER OF ACTIVE INDEX NODES: [" + (userInteraction.maxIndex + 1) + "] \n" +
				"CURRENT DISPLAY INDEX: [" + userInteraction.nodeIndex + "]"
			;

			if(!userInteraction.displayDebugText){
				screenText.enabled = false;
			}
			else if(userInteraction.displayDebugText){
				screenText.enabled = true;
			}



		}


	}
}
