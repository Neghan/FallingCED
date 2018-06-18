using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckNumOfBoxes : MonoBehaviour {
	public GameObject cam;
	public GameObject ball;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (GameObject.FindGameObjectsWithTag ("cubos").Length);
		if (GameObject.FindGameObjectsWithTag ("cubos").Length <= 4) {
			cam.GetComponent<CameraLookAt> ().onetime = false;
			ball.GetComponent<Movement> ().fallen = true;
		}
	}
}
