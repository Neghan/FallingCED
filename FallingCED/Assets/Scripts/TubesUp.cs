using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubesUp : MonoBehaviour {
    Vector3 up;
	Vector3 start;
	float speed = 4;
	// Use this for initialization
	void Start () {
		start = transform.position;
		up = new Vector3 (transform.position.x, transform.position.y+45, transform.position.z);
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x,transform.position.y+Time.deltaTime*speed,transform.position.z);
		if (transform.position.y >= up.y) {
			start = transform.parent.position;
			transform.position = start;
			up = new Vector3 (transform.position.x,transform.position.y+45,transform.position.z);

		}
	}
}
