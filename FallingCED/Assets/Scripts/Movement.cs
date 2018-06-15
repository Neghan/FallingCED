using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float speed = 10.0f;
	int status=0;
	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (-3.0f,8.0f,-1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("d")) {
			status = 1;
		} else if (Input.GetKeyDown ("a")) {
			status = 2;
		}

		if (Input.GetKeyUp("a")||Input.GetKeyUp("d") ) {
			status = 0;
		}

		if (status==1) {
			transform.position = new Vector3 (transform.position.x + Time.deltaTime * speed, transform.position.y,transform.position.z);
		} else if(status==2){
			transform.position=  new Vector3(transform.position.x - Time.deltaTime * speed,transform.position.y,transform.position.z);
		}
	}
}
