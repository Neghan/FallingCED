using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ValueSet : MonoBehaviour {
	public GameObject Cubo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text> ().text = ""+Cubo.GetComponent<Detection> ().mylife;
	}
}
