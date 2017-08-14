using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Response : MonoBehaviour {

	[Header("References")]
	public ThoughtManager thoughtManager;

	[Space]

	[Header ("Response Text")]
	public string[] responses;
	public Text responseText;

	[Space]

	[Header ("Go To")]
	public int[] goToIndex;
	public int goTo;

	void Update(){

		responseText.text = responses[thoughtManager.index];
	}

	public void GoToThisIndex(){
		goTo = goToIndex[thoughtManager.index];
		thoughtManager.index = goTo;
	}

}
