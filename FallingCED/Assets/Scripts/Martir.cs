using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Martir : MonoBehaviour {
	public GameObject explosion;
	AudioSource soun;
	public AudioClip soundE;
	GameObject []cube = new GameObject[8];

	void OnTriggerEnter(Collider cubos){
		if (cubos.tag == "cubos") {
			
		}
	}

	IEnumerator Detonate(){
		yield return new WaitForSeconds (3.0f);
		Destroy (Instantiate (explosion, transform.position, Quaternion.identity), 2);
		for (int i = 0; i < cube.Length; ++i) {
			if (Vector3.Distance (transform.position, cube [i].transform.position) <= 2) {
				cube [i].GetComponent<Detection> ().mylife = 0;
			}
		}
		Destroy (gameObject);
		yield return null;
	}
	// Use this for initialization
	void Start () {
		soun = GetComponent<AudioSource> ();
		cube = GameObject.FindGameObjectsWithTag("cubos");
		StartCoroutine (Detonate ());
	}
	
	// Update is called once per frame
	void Update () {
		cube = GameObject.FindGameObjectsWithTag("cubos");
	}
}
