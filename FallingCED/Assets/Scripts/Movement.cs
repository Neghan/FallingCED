using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float speed = 10.0f;
	int status=0;
	bool once=true;
	bool onetime;
	public bool menu;
	public int points;
	public bool fallen;
	private Vector2 touchOrigin = -Vector2.one;
	// Use this for initialization
	void Start () {
		if (!menu) {
			transform.position = new Vector3 (-3.0f, 8.0f, -1.5f);
		}
	}

	void OnTriggerEnter(Collider box){
		if (box.tag == "cubos"&&once) {
			//FORCE
			GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, 0,0);
			GetComponent<Rigidbody>().AddForce(new Vector3(0,400,0));
			points++;
			once = false;
		}
	}
	void OnTriggerExit(Collider box){
		if (box.tag == "cubos"&&!once) {
			once = true;
		}
	}

	// Update is called once per frame
	void Update () {
		if (!menu){
			//IPHONE 
			if (Input.touchCount > 0) {
				Touch myTouch = Input.touches [0];
				if (myTouch.phase == TouchPhase.Began) {
					touchOrigin = myTouch.position;
				} else if (myTouch.phase == TouchPhase.Ended && touchOrigin.x >= 0) {
					Vector2 touchEnd = myTouch.position;
					float x = touchEnd.x - touchOrigin.x;
					touchOrigin.x = -1;
					if (x > 0) {
						status = 1;
						onetime = true;
					} else if (x < 0) {
						status = 2;
						onetime = true;
					}
				}
			}
			//PC
			if (Input.GetKeyDown ("d")) {
				

				status = 1;
				onetime = true;
			} else if (Input.GetKeyDown ("a")) {
				status = 2;
				onetime = true;
			}

			if (Input.GetKeyUp ("a") || Input.GetKeyUp ("d")) {
				status = 0;
			}

			if (status == 1 && onetime) {
				GetComponent<Rigidbody> ().velocity = new Vector3 (0, GetComponent<Rigidbody> ().velocity.y, GetComponent<Rigidbody> ().velocity.z);
				GetComponent<Rigidbody> ().AddForce (new Vector3 (150, 0, 0));
				onetime = false;
			} else if (status == 2 && onetime) {
				GetComponent<Rigidbody> ().velocity = new Vector3 (0, GetComponent<Rigidbody> ().velocity.y, GetComponent<Rigidbody> ().velocity.z);
				GetComponent<Rigidbody> ().AddForce (new Vector3 (-150, 0, 0));
				onetime = false;
			}
		}
	}
}
