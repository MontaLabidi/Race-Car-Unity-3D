using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class position : MonoBehaviour {
	//public Text posLabel;
	//public GameObject tracker;
	//public GameObject [] car;
	//public int currentpos =1;
	  

	public static int [] pos = new int[5];
	void Start(){
		for (int i = 0; i <5; i++) {
			pos [i] = 0;
		}
	}

	void OnTriggerEnter (Collider collision){

		if (collision.gameObject.tag == "montacar1") {

			pos [0] += 1;

		} else if (collision.gameObject.tag == "montacar2") {
			
			pos [1] += 1;

		} else if (collision.gameObject.tag == "montacar3") {
			
			pos [2] += 1;

		} else if (collision.gameObject.tag == "montacar4") {
			
			pos [3] += 1;

		}else if (collision.gameObject.tag == "montacar5") {

			pos [4] += 1;

		} 

	
}
}