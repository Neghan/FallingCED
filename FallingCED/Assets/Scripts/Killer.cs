using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour {
	public float decrease;
	void OnTriggerEnter(Collider cubes){
		if(cubes.tag=="cubos"){
			Debug.Log ("well");
			decrease = cubes.gameObject.GetComponent<Detection> ().mylife;
			Destroy (cubes.gameObject);
			decrease = 0;
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
