using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class positioncheck : MonoBehaviour {

	public GameObject tracker;
	public GameObject [] car;
	public int currentpos =1;
	public Text posLabel;

	private int n;
	void Start() {
		n = choose.num;
		}
	public void Update (){
		getpos ();
	}
	void getpos (){
		currentpos = 1;
		
		for (int i = 0; i <5; i++) {
			if (i == n)
				continue;
			if (position.pos [i] > position.pos[n])
				currentpos += 1;
			else if (position.pos[i] == position.pos [n]) {
				if (Vector3.Distance (tracker.transform.position, car [i].transform.position) < Vector3.Distance (tracker.transform.position, car [n].transform.position))
					currentpos += 1;
			}
		}
		posLabel.text=currentpos.ToString("0");
	}
}
