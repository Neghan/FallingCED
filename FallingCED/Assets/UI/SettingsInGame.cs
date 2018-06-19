﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SettingsInGame : MonoBehaviour {
	public GameObject KCamera;
	public GameObject Mute;
	public GameObject Controls;

	bool sw = true;
	public void Settings(){
		sw = !sw;
		if (!sw) {
			Time.timeScale = 0;
			KCamera.GetComponent<Image> ().color = new Color (KCamera.GetComponent<Image> ().color.r,KCamera.GetComponent<Image> ().color.g,KCamera.GetComponent<Image> ().color.b,0.39f);
			Mute.SetActive(true);
			Controls.SetActive(true);
		} else {
			Time.timeScale = 1;
			KCamera.GetComponent<Image> ().color = new Color (KCamera.GetComponent<Image> ().color.r,KCamera.GetComponent<Image> ().color.g,KCamera.GetComponent<Image> ().color.b,0);
			Mute.SetActive(false);
			Controls.SetActive(false);
		}

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
