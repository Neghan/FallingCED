using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {
	public bool swit=true;
	GameObject []primero = new GameObject[4];  
	//GameObject []segundo = new GameObject[4];  
	public GameObject prefab;
	static Vector3 initPos = new Vector3(-3.0f,3.0f,-1.5f);

	int linesx;
	bool unavez;


	void generateLine(GameObject [] lineaParaLlenar,int length,int numeroLinea){
		Vector3 pos = new Vector3 (initPos.x, initPos.y - 5 * numeroLinea, initPos.z);
		for(int i = length - 1; i >= 0; i--){
			lineaParaLlenar [i] = Instantiate (prefab,pos,Quaternion.identity);
			pos = new Vector3 (pos.x + 2,pos.y,pos.z);
		}
	}

	// Use this for initialization
	void Start () {
		if (swit) {
			linesx = 0;
			generateLine (primero, primero.Length, linesx);
			linesx++;
			generateLine (primero, primero.Length, linesx);
		}
	}


	// Update is called once per frame
	void Update () {
		if (GetComponent<Movement> ().fallen == true && !unavez) {
			linesx++;
			generateLine (primero, primero.Length, linesx);

			unavez = true;
		}
		if (GetComponent<Movement> ().fallen == false){
			unavez = false;
		}
	}
}
