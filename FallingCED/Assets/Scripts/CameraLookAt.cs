using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour {
	float nextYCam;
	public bool onetime;
	// Use this for initialization
	void Start () {
		
	}

	IEnumerator LerpFromTo (Vector3 pos1, Vector3 pos2, float duration){
		for (float t = 0f; t < duration; t += Time.deltaTime) {
			transform.position = Vector3.Lerp (pos1, pos2, t / duration);
			yield return 0;
		}
		transform.position = pos2;
	}


	// Update is called once per frame
	void Update () {
		
		if (GameObject.FindGameObjectWithTag ("pelota").GetComponent<Movement> ().fallen == false&&onetime) {
			onetime = false;
		}
		//transform.LookAt (GameObject.FindGameObjectWithTag ("pelota").transform);
		if (GameObject.FindGameObjectWithTag ("pelota").GetComponent<Movement> ().fallen && !onetime ){
			nextYCam = transform.position.y - 5;
			StartCoroutine(LerpFromTo(transform.position,new Vector3 (0, nextYCam, -8),1.5f));
			onetime = true;
			//transform.position = new Vector3 (0, GameObject.FindGameObjectWithTag ("pelota").transform.position.y + 2, -8);
		}
	}
}
