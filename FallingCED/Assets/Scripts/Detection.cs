using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour {
	public float mylife;
	bool imDead;
	float frameCount = 0;
	public float timeDelay = 0.5f;

	void OnTriggerEnter(Collider ball){
		if(ball.gameObject.CompareTag("pelota")){
			mylife--;
		}
	}
	// Use this for initialization
	void Start () {
		mylife = Random.Range (1, 10);
	}
	
	// Update is called once per frame
	void Update () {
		if (mylife <= 0 && !imDead) {
			imDead = true;
			frameCount = Time.fixedTime;

		}
		//DELAY DE MUERTE
		if(imDead && Time.fixedTime - frameCount > timeDelay) {
			Destroy (this.gameObject);
		}
	}
}
