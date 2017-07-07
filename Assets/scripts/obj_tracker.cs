using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class obj_tracker: MonoBehaviour {
	public GameObject checkpoints;
	public GameObject otherUI;

	private int i=0;
	private GameObject checkp;
	public Text lapLabel;
	public Text mainlabel;
	private int lap=1;
	private int pos;
	public GameObject[] otherUIElements;
	private string tagi;
	private int bonus;

	Color gold =new Color32(0xD4,0xAF,0x37,0xFF);
	Color silver =new Color32(0xC0,0xC0,0xC0,0xFF);
	Color bronze =new Color32(0xCD,0x7F,0x32,0xFF);

	void Start(){
		tagi = "montacar" + (choose.num +1).ToString ("0");
		lapLabel.text=lap.ToString("0")+"/2";
		checkp= checkpoints.transform.GetChild (i).gameObject;
		this.transform.position = checkp.transform.position;
		this.transform.rotation = checkp.transform.rotation;
		}

	 void OnTriggerEnter (Collider collision){
		if (i > 32 && collision.gameObject.tag == tagi){
			bonus=100*SceneManager.GetActiveScene().buildIndex; 
			i =-1;
			lap++;
			if (lap == 3) {
				Time.timeScale = 0.7f;
				AudioListener.volume = 0.3f;
				pos = checkpoints.GetComponent<positioncheck> ().currentpos;
				otherUI.gameObject.SetActive (true);
				GameObject.FindObjectOfType<positioncheck>().car[choose.num].AddComponent<RCC_AICarController>();
				switch (pos) {
				case 1:
					mainlabel.GetComponent<Text> ().color = gold;
					mainlabel.text = "CONGRATULATION !\n\n\n YOU FINNISHED \n\n\n1st\n\n\n+"+bonus.ToString("0")+"pt";
					PlayerPrefs.SetInt ("score", PlayerPrefs.GetInt ("score")+bonus);
					break;
				case 2:
					mainlabel.GetComponent<Text> ().color = silver;
					mainlabel.text = "YOU FINNISHED \n\n\n2nd \n\n\n+"+(bonus/2).ToString("0")+"pt";
					PlayerPrefs.SetInt ("score", PlayerPrefs.GetInt ("score")+bonus/2);
					break;
				case 3:
					mainlabel.GetComponent<Text> ().color = bronze;
					mainlabel.text = "YOU FINNISHED \n\n\n3rd \n\n\n+"+(bonus/4).ToString("0")+"pt";
					PlayerPrefs.SetInt ("score", PlayerPrefs.GetInt ("score") +bonus/4);
					break;
				case 4:
					mainlabel.GetComponent<Text> ().color = Color.red;
					mainlabel.text = "YOU FINNISHED \n\n\n4th \n\n\n YOU LOST!";break;
				case 5:
					mainlabel.GetComponent<Text> ().color = Color.red;
					mainlabel.text = "YOU FINNISHED \n\n\n5th \n\n\n YOU LOST!";break;
			
				}
				for (int i = 0; i < otherUIElements.Length; i++)
				{
					otherUIElements[i].gameObject.SetActive(false);
				}
			}
			lapLabel.text=lap.ToString("0")+"/2";
		}
		if (collision.gameObject.tag == tagi) {
			i++;

			checkp = checkpoints.transform.GetChild (i).gameObject;
			this.transform.position = checkp.transform.position;
			this.transform.rotation = checkp.transform.rotation;

		}


	}
}

