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

	public MeshRenderer a;
	public MeshRenderer b;
	public MeshRenderer c;

	Color CurrentColor;
	Color red;
	Color green;
	Color blue;

	IEnumerator LerpFromTo (Vector3 pos1, Vector3 pos2, float duration){
		for (float t = 0f; t < duration; t += Time.deltaTime) {
			transform.parent.position = Vector3.Lerp (pos1, pos2, t / duration);
			yield return 0;
		}
		transform.parent.position = pos2;
		start = true;
		StartCoroutine (ColorChanger ());
	}
	IEnumerator ColorChanger(){
		while (transform.parent.position.y >= pos - 50.0f) {
			a.material.color = new Color (255, 255, 255, 1);
			b.material.color = new Color (255, 255, 255, 1);
			c.material.color = new Color (255, 255, 255, 1);
			GetComponentInParent<MeshRenderer> ().material.color = new Color (255, 255, 255, 1);
			yield return new WaitForSeconds (0.1f);
			a.material.color = red;
			b.material.color = green;
			c.material.color = blue;
			GetComponentInParent<MeshRenderer> ().material.color = CurrentColor;
			yield return new WaitForSeconds (0.1f);
		}
	}

	void OnTriggerEnter(Collider ball){
		if(ball.tag == "pelota"){
			GameObject.FindGameObjectWithTag ("pelota").GetComponent<Movement> ().fallen = true;
			StartCoroutine(LerpFromTo(transform.parent.position,new Vector3 (GetComponentInParent<Transform> ().position.x, GetComponentInParent<Transform> ().position.y, GetComponentInParent<Transform> ().position.z+3),0.5f));

		}
	}
	void OnTriggerExit(Collider ball){
		if(ball.tag == "pelota"){
			GameObject.FindGameObjectWithTag ("pelota").GetComponent<Movement> ().fallen = false;
			GetComponent<Collider> ().enabled = false;
		}
	}
	// Use this for initialization
	void Start () {
		CurrentColor = GetComponentInParent<MeshRenderer> ().material.color;
		red = a.material.color;
		green = b.material.color;
		blue = c.material.color;
		HP = GameObject.FindGameObjectWithTag ("UI");
		sound = GetComponent<AudioSource> ();
		pos = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (start == true) {

			transform.parent.position = new Vector3 (GetComponentInParent<Transform> ().position.x, GetComponentInParent<Transform> ().position.y + Time.deltaTime * speed, GetComponentInParent<Transform> ().position.z);

			if (transform.parent.position.y <= pos-50.0f) {
				HP.GetComponent<HP>().health-=GetComponentInParent<Detection> ().mylife;
				sound.PlayOneShot (fail);
				start = false;
				Destroy (transform.parent.gameObject);
			}
		}	
	}
}
