using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

	public GameObject thecar;
	public float carx;
	public float cary;
	public float carz;
	void Update () {
		carx = thecar.transform.eulerAngles.x;
		cary = thecar.transform.eulerAngles.y;
		carz = thecar.transform.eulerAngles.z;
		transform.eulerAngles = new Vector3 (0, cary, 0);
	}
	/*void FixedUpdate (){
		transform.eulerAngles = new Vector3 (0, cary, 0);
	}*/
}
