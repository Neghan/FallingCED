using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationUI : MonoBehaviour {
	// Use this for initialization
	void Start () {
		StartCoroutine (Coro());
	}
	
	// Update is called once per frame
	void Update () {
			
	}
	IEnumerator Coro(){
		while (true) {
			GetComponent<RectTransform> ().localScale = new Vector3 (1.1f, 1.1f, 1.1f);
			yield return new WaitForSeconds (0.5f);
			GetComponent<RectTransform> ().localScale = new Vector3 (1.0f, 1.0f, 1.0f);
		}
	}
}
