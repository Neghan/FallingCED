using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ValueSet : MonoBehaviour {
	public GameObject Cubo;
	public bool menu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!menu) {
			GetComponent<Text> ().text = "" + Cubo.GetComponent<Detection> ().mylife;
		}
	}
}
