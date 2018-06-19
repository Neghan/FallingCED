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
		//Debug.Log (ball.GetComponent<Movement> ().fallen);
		if (GameObject.FindGameObjectsWithTag ("cubos").Length <= 4) {
			ball.GetComponent<Movement> ().fallen = true;
		}
	}
}
