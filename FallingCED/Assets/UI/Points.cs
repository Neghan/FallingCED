using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Points : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
		GetComponent<Text>().text = ""+player.GetComponent<Movement>().points;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = ""+player.GetComponent<Movement>().points;
	}
}
