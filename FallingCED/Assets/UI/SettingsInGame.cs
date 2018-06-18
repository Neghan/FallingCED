using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SettingsInGame : MonoBehaviour {
	public GameObject KCamera;
	bool sw = true;
	public void Settings(){
		sw = !sw;
		if (!sw) {
			Time.timeScale = 0;
			//KCamera.GetComponent<Color> ().a = 100;
		} else {
			Time.timeScale = 1;
			//KCamera.GetComponent<Color> ().a = 0;
		}

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
