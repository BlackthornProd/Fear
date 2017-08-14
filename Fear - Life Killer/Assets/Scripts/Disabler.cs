using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Disabler : MonoBehaviour {

	public GameObject[] panels;
	//public Animator flash;
	public Animator redFlash;
	public Animator panel;

	public int index = 0;
	private int goToIndex;


	void Start(){

		panel.SetTrigger("Enter");
	}


	public void Next(){


		redFlash.SetBool("flashing", false);

		for (int i = 0; i < panels.Length; i++) {
			if(i == index){
				panels[i].SetActive(true);
			} else {
				panels[i].SetActive(false);
			}
		}
	}

	public void SceneTransiton(int indexScene){

		goToIndex = indexScene;
		StartCoroutine(SceneTrans());
	}

	IEnumerator SceneTrans(){

		panel.SetTrigger("Leave");
		yield return new WaitForSeconds(3f);
		SceneManager.LoadScene(goToIndex);
	}
}
