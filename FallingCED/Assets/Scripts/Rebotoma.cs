using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebotoma : MonoBehaviour {
	void OnTriggerEnter(Collider ball){
		if (ball.tag == "pelota") {
			if (Random.Range (1, 2) == 1) {
				ball.gameObject.GetComponent<Rigidbody> ().AddForce (15000, 0, 0);
			} else{
				ball.gameObject.GetComponent<Rigidbody> ().AddForce (-15000, 0, 0);
			}
			Destroy (gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
