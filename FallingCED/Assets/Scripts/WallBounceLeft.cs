using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBounceLeft : MonoBehaviour {
	bool onetime=true;
	public GameObject player;
	void OnTriggerEnter(Collider ball){
		//Debug.Log ("Entered");
		if (ball.tag == "pelota"&&onetime) {
			ball.GetComponent<Rigidbody>().velocity = new Vector3(-ball.GetComponent<Rigidbody>().velocity.x, ball.GetComponent<Rigidbody>().velocity.y,0);
			//ball.gameObject.GetComponent<Rigidbody> ().AddForce (player.GetComponent<Rigidbody>().velocity.x,0,0);
			onetime = false;
		}
	}
	void OnTriggerExit(Collider ball){
		if (ball.tag == "pelota") {
			onetime = true;
		}
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
