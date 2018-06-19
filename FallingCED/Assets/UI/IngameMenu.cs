using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameMenu : MonoBehaviour {
	bool toggle = true;




	public void Mute(){
		toggle = !toggle;
		if (toggle) {
			AudioListener.volume = 1f;
		} else {
			AudioListener.volume = 0f;
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
