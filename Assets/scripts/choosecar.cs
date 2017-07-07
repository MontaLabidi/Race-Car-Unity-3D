using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class choosecar : MonoBehaviour
{
	private int score;
	public Text [] carlabels=new Text[5];
	public Text [] buttonlabels=new Text[5];
	public Text scorelabel;

	void Start ()
	{
		score = PlayerPrefs.GetInt ("score");
		scorelabel.text = "score : " + score.ToString ("0");
		for (int i = 0; i < 5; i++) {
			
			if (score >= i * 1000) {
				carlabels [i].text = "UNLOCKED";
			   buttonlabels [i].text = "CHOOSE";
				buttonlabels [i].GetComponent<Text> ().color = Color.green;
			} else {
				carlabels [i].text = i * 1000 + " \nTO UNLOCK";
				buttonlabels [i].text = "LOCKED";
				buttonlabels [i].GetComponent<Text> ().color = Color.red;
			}

		}
	

	
	}
}

