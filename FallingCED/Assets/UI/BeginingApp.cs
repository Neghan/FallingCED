using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeginingApp : MonoBehaviour {
	public GameObject Musc;
	public AudioClip a;
	// Use this for initialization
	void Start () {
		StartCoroutine (Fadeya ());
	}
	
	// Update is called once per frame
	IEnumerator Fadeya(){
		CanvasGroup can = GetComponent<CanvasGroup> ();
		yield return new WaitForSeconds (3.0f);
		while (can.alpha > 0) {
			can.alpha -= Time.deltaTime/2;
			yield return null;
		}
		can.interactable = false;
		Musc.GetComponent<AudioSource> ().clip = a;
		Musc.GetComponent<AudioSource> ().PlayOneShot (a);
		yield return null;
	}
}
