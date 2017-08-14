using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fear : MonoBehaviour {

	public int fear = 0;

	public Image playerImage;
	public Sprite[] playerStates;

	void Update(){

		Debug.Log(fear);

		if(fear > 100){
			fear = 100;
		} else if(fear < 0){
			fear = 0;
		}


		if(fear >= 0 && fear < 25){
			playerImage.sprite = playerStates[0];
		} else if(fear >= 25 && fear < 50){
			playerImage.sprite = playerStates[1];	
		} else if(fear >= 50 && fear < 75){
			playerImage.sprite = playerStates[2];
		} else if(fear >= 75 && fear <= 100){
			playerImage.sprite = playerStates[3];
		}	
	}
}
