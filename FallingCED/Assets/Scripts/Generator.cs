using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {
	public bool swit=true;
	GameObject []primero = new GameObject[4];  
	//GameObject []segundo = new GameObject[4];  
	public GameObject prefab;
	public GameObject Rebotoma;
	public GameObject Mitosis;
	public GameObject Martir;
	public GameObject triggerer;
	static Vector3 initPos = new Vector3(-3.0f,3.0f,-1.5f);

	int linesx;
	bool unavez;


	void generateLine(GameObject [] lineaParaLlenar,int length,int numeroLinea){
		Vector3 pos = new Vector3 (initPos.x, initPos.y - 5 * numeroLinea, initPos.z);
		for (int i = length - 1; i >= 0; i--) {
			lineaParaLlenar [i] = Instantiate (prefab, pos, Quaternion.identity);
			pos = new Vector3 (pos.x + 2, pos.y, pos.z);
		}
		//Instantiate (triggerer,  pos, Quaternion.identity);
		Vector3 pos1 = new Vector3 (2+initPos.x,1.6f+initPos.y -5* numeroLinea, initPos.z);
		Vector3 pos2 = new Vector3 (4+initPos.x,1.6f+initPos.y -5* numeroLinea, initPos.z);
		Vector3 pos3 = new Vector3 (3+initPos.x,2.6f+initPos.y -5* numeroLinea, initPos.z);
		if (Random.Range (1, 4) == 3) {
			Instantiate (Rebotoma, pos1, Quaternion.Euler (0, 180, 0));
		}
		if (Random.Range (1, 4) == 1) {
			Instantiate (Mitosis,pos2 , Quaternion.Euler(0,180,0));
		}
		if (Random.Range (1, 4) == 2) {
			Instantiate (Martir,pos3 , Quaternion.Euler(0,180,0));
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
		if (swit) {
			if (GetComponent<Movement> ().fallen == true && !unavez) {
				linesx++;
				generateLine (primero, primero.Length, linesx);

				unavez = true;
			}
			if (GetComponent<Movement> ().fallen == false) {
				unavez = false;
			}
		}
	}
}
