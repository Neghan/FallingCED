using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerC : MonoBehaviour {
	bool job;

	void OnTriggerEnter(Collider ball){
		
		if (ball.tag == "pelota") {
			GameObject.FindGameObjectWithTag ("pelota").GetComponent<Movement> ().fallen = true;
		}
	}
	void OnTriggerExit(Collider ball){
		if (ball.tag == "pelota") {
			
			GameObject.FindGameObjectWithTag ("pelota").GetComponent<Movement> ().fallen = false;
			job = true;
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (job == true) {
			//Destroy (gameObject);
		}
	}
}
