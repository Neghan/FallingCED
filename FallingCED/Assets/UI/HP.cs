using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HP : MonoBehaviour {
	public GameObject player;

	public float health= 100;
	// Use this for initialization
	void Start () {
		GetComponent<Text>().text = ""+health;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (health <= 0) {
			GetComponent<Text> ().text = "" + 0;
			Destroy (player.gameObject);
		} else {
			GetComponent<Text>().text = ""+health;
		}
	}
}
