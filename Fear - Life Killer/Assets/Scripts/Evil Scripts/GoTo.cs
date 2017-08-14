using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoTo : MonoBehaviour {

	public ThoughtManager thoughtManager;

	public int[] goToIndex;
	public int goTo;



	public void Update(){
		
	}

	public void GoToThisIndex(){
		goTo = goToIndex[thoughtManager.index];
		Debug.Log("Go to : " + goTo);
		thoughtManager.index = goTo;
		Debug.Log("Index : " + thoughtManager.index);
	}
}
