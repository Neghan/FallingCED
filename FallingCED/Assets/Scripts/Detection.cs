using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Detection : MonoBehaviour {
	public float mylife;
	bool imDead;
	float frameCount = 0;
	public float timeDelay = 0.5f;
	public bool menu;
	int wichcolor;

	public AudioClip one;
	public AudioClip two;
	public AudioClip three;
	AudioSource sound;

	GameObject rebotoma;

	public GameObject redMesh;
	public GameObject greenMesh;
	public GameObject blueMesh;

	public GameObject redlight;
	public GameObject bluelight;
	public GameObject greenlight;

	bool canEnter=true;

	float wich;
	public float movespeed = 2.0f;
	public float amount = 1.0f;
	Vector3 startpos;

	void Type(){
		wich = Random.Range (0, 2);
	}



	void OnTriggerEnter(Collider ball){
		if(ball.gameObject.CompareTag("pelota")&&canEnter){
			if (!menu) {
				if(mylife>0)
				mylife--;
				
				canEnter = false;
			}
			//JUST FOR MENU
			canEnter = false;
			wichcolor = Random.Range (1, 4);
			//RED
			if (wichcolor == 1) {
				GetComponent<MeshRenderer> ().enabled = false;
				redlight.GetComponent<MeshRenderer> ().enabled = true;
				blueMesh.GetComponent<MeshRenderer> ().enabled = false;
				greenMesh.GetComponent<MeshRenderer> ().enabled = false;
				redMesh.GetComponent<MeshRenderer> ().enabled = true;
				sound.PlayOneShot (one);
			//BLUE
			} else if (wichcolor == 2) {
				GetComponent<MeshRenderer> ().enabled = false;
				bluelight.GetComponent<MeshRenderer> ().enabled = true;
				redMesh.GetComponent<MeshRenderer> ().enabled = false;
				greenMesh.GetComponent<MeshRenderer> ().enabled = false;
				blueMesh.GetComponent<MeshRenderer> ().enabled = true;
				sound.PlayOneShot (two);
			//GREEN
			} else if (wichcolor == 3) {
				GetComponent<MeshRenderer> ().enabled = false;
				greenlight.GetComponent<MeshRenderer> ().enabled = true;
				blueMesh.GetComponent<MeshRenderer> ().enabled = false;
				redMesh.GetComponent<MeshRenderer> ().enabled = false;
				greenMesh.GetComponent<MeshRenderer> ().enabled = true;
				sound.PlayOneShot (three);
			}

		}
	}
	IEnumerator LightsOut(){
		yield return new WaitForSeconds (0.15f);
		redlight.GetComponent<MeshRenderer> ().enabled = false;
		greenlight.GetComponent<MeshRenderer> ().enabled = false;
		bluelight.GetComponent<MeshRenderer> ().enabled = false;
	}
	void OnTriggerExit(Collider ball){
		if (ball.gameObject.CompareTag ("pelota")&&!canEnter) {
			StartCoroutine (LightsOut ());
			canEnter = true;
		}
	}

	IEnumerator ChangeColors(){
		
			GetComponent<MeshRenderer> ().material.color = new Color (255, 34, 34, 1);
			yield return new WaitForSeconds(0.8f);
			GetComponent<MeshRenderer> ().material.color = new Color (41, 204, 0, 1);
			yield return new WaitForSeconds(0.8f);
			GetComponent<MeshRenderer> ().material.color = new Color (0, 103, 204, 1);

	}

	// Use this for initialization
	void Start () {
		mylife = Random.Range (1, 10);
		sound = GetComponent<AudioSource> ();
		Type ();
		//TYPE
		if (wich == 0) {
			//Instantiate(
		} else if (wich == 1) {

		} else if (wich == 2) {

		}
		startpos = transform.position;
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
