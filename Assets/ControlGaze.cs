using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlGaze : MonoBehaviour {
	
	private bool counter; //カウンタ
	private float time; //経過時間

	// Use this for initialization
	void Start () {
		counter = false;
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (counter) {
			time += Time.deltaTime;

			if (time >= 2) {
				Debug.Log("Gaze");
				GetComponent<Renderer>().material.color = counter ? Color.green : Color.red;
				// SceneManager.LoadScene ("Panorama Viewer");
			}
		}
	}

	public void enterPointer(){
		Debug.Log ("Enter Pointer");
		counter = true;
	}

	public void exitPointer(){
		Debug.Log ("Exit Pointer");
		counter = false;
		time = 0;
	}

}