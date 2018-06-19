using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {
	public GameObject swipeleft;
	public GameObject swiperight;
	bool sw=true;
	// Use this for initialization
	public void ControlClicked(){
		sw = !sw;
		if (sw == false) {
			swipeleft.SetActive (true);
			swiperight.SetActive (true);
		} else {
			swipeleft.SetActive (false);
			swiperight.SetActive (false);
		}
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
