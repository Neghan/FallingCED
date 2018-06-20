using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SettingsInGame : MonoBehaviour {
	public GameObject KCamera;
	public GameObject Mute;
	public GameObject Controls;
	public GameObject Controls1;
	public GameObject Controls2;

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
			Controls1.SetActive (false);
			Controls2.SetActive (false);
			Controls.GetComponent<Controls> ().sw = true;
		}

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
