using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Martir : MonoBehaviour {
	public GameObject explosion;
	AudioSource soun;
	public AudioClip soundE;
	GameObject[] cubes = new GameObject[4];
	int i = 0;
	void OnTriggerEnter(Collider cubos){
		if (cubos.tag == "cubos") {
			Debug.Log ("Added");
			cubes [i] = cubos.gameObject;
			i++;
		}
	}

	IEnumerator Detonate(){
		yield return new WaitForSeconds (3.0f);
		/*for (int j = 0; j < cubes.Length; ++i) {
			cubes [i].GetComponent<Detection> ().mylife--;
		}*/
		yield return new WaitForSeconds (1.0f);
		Destroy (Instantiate (explosion, transform.position, Quaternion.identity), 2);

		Destroy (gameObject);
	}
	// Use this for initialization
	void Start () {
		soun = GetComponent<AudioSource> ();
		StartCoroutine (Detonate ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
