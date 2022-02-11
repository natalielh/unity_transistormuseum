using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //need to import UnityEngine.UI to control the text displayed on the GUI

public class InfoTextMain : MonoBehaviour {

	public UserInteraction userInteraction;
	Text mainText;

	string[] descriptionArray = new string[30];	//increase the number at the end if you need more, this can be greater than maxIndex
	//List<string> descriptionArray = new List<string>();

	// Use this for initialization
	void Start () {

		userInteraction = GameObject.Find("GameController").GetComponent<UserInteraction>();
		mainText = GetComponent<Text>();

		// THE TEXT:
		// \n puts 'enter' in the string
		////
		descriptionArray [0] =
			"<b>Welcome to the Transistor Museum!</b> \n" +
			"\n" +
			"<b>Navigation:</b> \n" +
            "• Arrow keys (left and right) \n" +
            "• A and D keys (left and right) \n" +
            "• Mouse (horizontal rotation) \n" +
            "• ESC to quit \n" +
			"\n" +
            "<b>Created by:</b> \n" +
			"Vivian Fu \n" +
			"Erika Davis \n" +
			"Natalie Le Huenen \n" +
			"\n" +
			"Thanks for playing!";

		//vacuum tubes
		descriptionArray[1] =
			"1910 \n" +
            "<b>Vacuum Tube</b> \n" +
			"\n" +
            "The first transistors created were tubes: more specifically the vacuum tube. The early renditions of the vacuum tubes include triodes. It's a device that controls electric current between electrodes in a container. Vacuum tubes rely on emission of electrons from a hot filament or a cathode heated by the filament. ";

		descriptionArray[2] =
			"1930 \n" +
            "<b>Vacuum Tube</b> \n" +
            "\n" +
			"The first transistors created were tubes: more specifically the vacuum tube. The early renditions of the vacuum tubes include triodes. It's a device that controls electric current between electrodes in a container. Vacuum tubes rely on emission of electrons from a hot filament or a cathode heated by the filament. ";

		descriptionArray[3] =
			"1941 \n" +
            "<b>Vacuum Tube</b> \n" +
            "\n" +
			"The first transistors created were tubes: more specifically the vacuum tube. The early renditions of the vacuum tubes include triodes. It's a device that controls electric current between electrodes in a container. Vacuum tubes rely on emission of electrons from a hot filament or a cathode heated by the filament. ";

		descriptionArray[4] =
			"1946 \n" +
            "<b>Vacuum Tube</b> \n" +
            "\n" +
			"The first transistors created were tubes: more specifically the vacuum tube. The early renditions of the vacuum tubes include triodes. It's a device that controls electric current between electrodes in a container. Vacuum tubes rely on emission of electrons from a hot filament or a cathode heated by the filament. ";

		descriptionArray[5] =
			"1948 \n" +
            "<b>Point-Contact Transistor</b> \n" +
			"\n" +
			"In 1948, improvements were done to the triodes to create the point-contact transistor. They were experimenting with electric field effects in solid state materials, with the aim of replacing vacuum tubes with a smaller, power efficient device.";

		descriptionArray[6] =
			"1955 \n" +
            "<b>Bipolar Junction Transistor</b> \n" +
			"\n" +
			"After 1955, bipolar junction transistors were within network communications equipment as they replaced vacuum tubes. They were transistors that used both electron and hole carriers.";

		descriptionArray[7] =
			"1957 \n" +
            "<b>Diffusion Transistor</b> \n" +
			"\n" +
			"In 1957, diffusion transistors were created by diffusing dopants into a semiconductive substrate. These transistors had alloy emitters and collectors. The base was diffused into the substrate and at times, it formed the collector.";

		descriptionArray[8] =
			"1959 \n" +
            "<b>Integrated Circuit</b> \n" +
			"\n" +
			"By the late 1950's, the transistor became an integral part of the electronic telephone switching system, but also a key component of other important products and services, such as portable radios, computers, and radar. \n" +
			"\n" +
			"As the semiconductor technology improved, the transistor became faster, cheaper, and reliable. In 1959, a huge breakthrough took place with the invention of the integrated circuit-- the ability to organize numerous transistors and other electronic components on a silicon wafer--complete with wiring. These microchips advanced the transistor innovation and promoted the evolution of the Information Age.";

		descriptionArray [9] =
			"1967 \n" +
            "<b>Microchip</b> \n" +
			"\n" +
			"In 1967, the microchip was introduced. The microchip was part of a touch-tone telephone set. The microchip was a set of electronic circuits on semiconductor material. It consists of many transistors that were fit into a small chip, thus resulting in circuits that were much cheaper, faster, and much smaller.";

		descriptionArray[10] =
			"1986 \n" +
            "<b>Microprocessor</b> \n" +
			"\n" +
			"The transistor is simply an on/off switch controlled by electricity, but in the 1960s the invention of the integrated circuit allowed the combination of numerous transistors onto a single chip.\nOver the years the technology behind transistors has changed so that they could be made smaller and more could be fitted into microprocessors giving faster processors. This can be observed through the generations of integrated circuits. This technology continues to make advances in miniaturization in manufacturing transistors and microprocessors.";

		descriptionArray[11] =
            "2000 \n" +
            "<b>Microprocessor</b> \n" +
            "\n" +
            "64-bit processors became mainstream in the 2000s. Microprocessor clock speeds reached a ceiling because of the heat dissipation barrier. Instead of implementing expensive and impractical cooling systems, manufacturers turned to parallel computing in the form of the multi-core processor. Overclocking had its roots in the 1990s, but came into its own in the 2000s. Off-the-shelf cooling systems designed for overclocked processors became common, and the gaming PC had its advent as well. Over the decade, transistor counts increased by about an order of magnitude, a trend continued from previous decades. Process sizes decreased about fourfold, from 180 nm to 45 nm.";

		descriptionArray[12] = "";

		descriptionArray[13] = "";

		descriptionArray[14] = "";
		////
	}
	
	// Update is called once per frame
	void LateUpdate () {

		if(Input.anyKey){
			mainText.text = descriptionArray[userInteraction.nodeIndex];

		}

	}
}
