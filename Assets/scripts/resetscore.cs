using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetscore : MonoBehaviour {


	public void reset () {
		PlayerPrefs.SetInt ("score", 0);
		
	}
	


}
