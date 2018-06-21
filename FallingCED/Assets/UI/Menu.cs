using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	bool toggle = true;

	public GameObject play;
	public GameObject settings;

	public GameObject mute;
	public GameObject controls;
	public GameObject control1;
	public GameObject control2;
	public GameObject back;

	public void Level(){
		SceneManager.LoadScene ("Game");
	}
	public void Mute(){
		toggle = !toggle;
		if (toggle) {
			AudioListener.volume = 1f;
		} else {
			AudioListener.volume = 0f;
		}
	}
	public void EnterSettings(){
		mute.SetActive (true);
		controls.SetActive (true);
		back.SetActive (true);

		play.SetActive (false);
		settings.SetActive (false);
	}
	public void ExitSettings(){
		mute.SetActive (false);
		controls.SetActive (false);
		back.SetActive (false);

		control1.SetActive (false);
		control2.SetActive (false);

		play.SetActive (true);
		settings.SetActive (true);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
