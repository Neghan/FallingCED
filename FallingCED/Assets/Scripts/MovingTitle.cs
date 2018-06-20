using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTitle : MonoBehaviour {
    public float speed;
	public bool axis;
	public bool floating;
	Vector3 startpos;
	// Use this for initialization
	void Start () {
		startpos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!axis)
			transform.Rotate (new Vector3 (0, -1, 0));
		else 
			transform.Rotate (new Vector3 (-1,0, 0));

		if (floating) {
			//transform.position = new Vector3 (startpos.x, startpos.y*Mathf.Sin(Time.deltaTime)*0.2f, startpos.z);
		}
	}
}
