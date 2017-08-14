using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThoughtManager : MonoBehaviour {

	public int index = 0;

	[Space]

	[Header ("References")]
	public Variables variables;
	public Text thoughText;

	void Update(){

		thoughText.text = variables.thoughts[index];
	}

}
