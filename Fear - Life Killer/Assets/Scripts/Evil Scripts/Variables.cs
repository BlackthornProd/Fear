using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {

	[Header ("Thought Text")]
	public ThoughtManager thoughtManager;
	[TextArea(3, 10)]
	public string[] thoughts;

	[Space]

	[Header ("Hide/Show Continue/Responses")]
	public GameObject continueButton;
	public GameObject responses;
	public bool[] showContinue;
	public bool[] showResponses;


	void Update(){

		if(showContinue[thoughtManager.index] == true){
			continueButton.SetActive(true);
		} else {
			continueButton.SetActive(false);
		}

		if(showResponses[thoughtManager.index] == true){
			responses.SetActive(true);
		} else {
			responses.SetActive(false);
		}
	}
}
