using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpMartir : MonoBehaviour {
	bool una;
	GameObject player1;



	void OnTriggerEnter(Collider pl){
		if (!una) {
			if (pl.tag == "pelota") {
				player1.GetComponent<Movement> ().martir = true;
				Destroy (gameObject);
				una = true;
			}
		}
	}
	// Use this for initialization
	void Start () {
		player1=GameObject.FindGameObjectWithTag ("pelota");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
