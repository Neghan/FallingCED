using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mitosis : MonoBehaviour {
	GameObject pelotica;
	GameObject instance;
	bool onetime;
	void OnTriggerEnter(Collider ball){
		if (ball.tag == "pelota") {
			if (!onetime){
				instance = Instantiate (pelotica, ball.gameObject.transform.position, Quaternion.identity);
				instance.GetComponent<Movement> ().menu = true;
				instance.GetComponent<Generator> ().swit = false;
				onetime = true;
			}
			Destroy (instance, 8);
			Destroy (gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		pelotica = GameObject.FindGameObjectWithTag ("pelota");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
