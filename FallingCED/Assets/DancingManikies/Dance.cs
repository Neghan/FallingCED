using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dance : MonoBehaviour {
	int numbe;
	public RuntimeAnimatorController a;
	public RuntimeAnimatorController b;
	GameObject cam;
	// Use this for initialization
	void Start () {
		cam = GameObject.FindGameObjectWithTag ("MainCamera");
		numbe = Random.Range (1, 3);
		if (numbe == 1) {
			GetComponent<Animator> ().runtimeAnimatorController = a;
		} else {
			GetComponent<Animator> ().runtimeAnimatorController = b;
		}
	}
	// Update is called once per frame
	void Update () {
		if (transform.position.y-cam.transform.position.y >= 5) {
			Destroy (gameObject);
		}
	}
}
