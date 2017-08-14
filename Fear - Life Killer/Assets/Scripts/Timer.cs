using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	[Header ("References")]
	private Disabler disabler;
	private Fear fear;
	//public Text timerText;
	public Animator flash;
	public Animator redFlash;

	[Space]

	[Header("Parameters")]
	public float time;
	public float flashTimer;
	public int goToPanelFail;
	public int fearBoost;

	void Start(){

		disabler = GameObject.FindGameObjectWithTag("Scene Manager").GetComponent<Disabler>();
		fear = GameObject.FindGameObjectWithTag("Fear").GetComponent<Fear>();
	}

	void Update(){


		if(time <= 0){
				if(flashTimer <= 0){
					redFlash.SetBool("flashing", false);
					flash.SetBool("Transform", false);
					fear.fear += fearBoost;
					disabler.index = goToPanelFail;
					disabler.Next();
				} else {
					redFlash.SetBool("flashing", true);
					flashTimer -= Time.deltaTime;
				}
			
			

		} else {
			redFlash.SetBool("flashing", false);
			flash.SetBool("Transform", true);
			time -= Time.deltaTime;
		}
	}
}
