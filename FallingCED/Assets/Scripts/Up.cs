using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Up : MonoBehaviour {
	bool start;
	public float speed = 5;
	public GameObject HP;

	public AudioClip fail;
	AudioSource sound;
	float pos;

	void OnTriggerEnter(Collider ball){
		if(ball.tag == "pelota"){
			
			start = true;
		}
	}
	// Use this for initialization
	void Start () {
		HP = GameObject.FindGameObjectWithTag ("UI");
		sound = GetComponent<AudioSource> ();
		pos = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (start == true) {
			GameObject.FindGameObjectWithTag ("pelota").GetComponent<Movement> ().fallen = true;
			transform.parent.position = new Vector3 (GetComponentInParent<Transform> ().position.x, GetComponentInParent<Transform> ().position.y + Time.deltaTime * speed, GetComponentInParent<Transform> ().position.z);
			if (transform.parent.position.y >= pos+10.0f) {
				HP.GetComponent<HP>().health-=GetComponentInParent<Detection> ().mylife;
				sound.PlayOneShot (fail);
				GameObject.FindGameObjectWithTag ("pelota").GetComponent<Movement> ().fallen = false;
				Destroy (transform.parent.gameObject);
			}
		}	
	}
}
