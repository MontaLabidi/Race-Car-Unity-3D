using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

	public int score; 
	public Text textLabel;
	void Start ()
	{ 	score=PlayerPrefs.GetInt ("score"); 
		if(score==0)
		PlayerPrefs.SetInt ("score",2900); 
		textLabel.text="Score : "+score.ToString("0");
	}

	public void getscore ()
	{
		score=PlayerPrefs.GetInt ("score"); 
		textLabel.text="Score : "+score.ToString("0");
	}
	

}

