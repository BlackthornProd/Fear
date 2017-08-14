using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour {

	private Disabler disabler;
	private Fear fear;
	public Animator bubble;
	public Animator[] buttons;

	public int goToPanel;
	public bool changeScene = false;
	public int sceneIndex;

	[Space]

	[Header ("Fear Parameters")]
	public int fearVisibility = 0;
	public bool causeFear = false;
	public int boost;




	void Awake(){
		bubble.SetTrigger("Enter");
		for (int i = 0; i < buttons.Length; i++) {
			buttons[i].SetTrigger("Enter");
		}
	}

	void Start(){

		disabler = GameObject.FindGameObjectWithTag("Scene Manager").GetComponent<Disabler>();
		fear = GameObject.FindGameObjectWithTag("Fear").GetComponent<Fear>();

	
	}


	void Update(){

		if(fearVisibility >= fear.fear){
			this.gameObject.SetActive(true);
		} else {
			this.gameObject.SetActive(false);
		}
	}

	public void NextIndex(){
		if(changeScene == false){
			StartCoroutine(PlayEndAnims());
		} else {
			disabler.SceneTransiton(sceneIndex);
		}

	}

	IEnumerator PlayEndAnims(){

		bubble.SetTrigger("Leave");
		for (int i = 0; i < buttons.Length; i++) {
			buttons[i].SetTrigger("Leave");
		}
		yield return new WaitForSeconds(0.2f);

		disabler.index = goToPanel;
		disabler.Next();

		if(causeFear == true){
			fear.fear += boost;
		} else {
			fear.fear -= boost;
		}
	}

}
