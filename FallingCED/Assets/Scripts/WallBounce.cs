using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBounce : MonoBehaviour {

	void OnTriggerEnter(Collider ball){
		if (ball.tag == "pelota") {
			ball.gameObject.GetComponent<Rigidbody> ().AddForce (-50,0,0);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
