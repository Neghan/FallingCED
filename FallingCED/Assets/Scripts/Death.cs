using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {
	public GameObject hp;
	public GameObject Resp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((hp.GetComponentInChildren<HP> ().health <= 0)) {
			Resp.SetActive (true);	
			Time.timeScale = 0;
		}
	}
}
