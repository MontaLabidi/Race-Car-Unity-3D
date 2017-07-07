using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO;
using UnityEngine.SceneManagement;

public class PauseManager1 : MonoBehaviour {
	
	public GameObject mainPanel;

	public GameObject vidPanel;

	public GameObject audioPanel;

	public GameObject TitleTexts;

	public GameObject mask;

	public Text pauseMenu;
	
	public void Start(){
		Time.timeScale = 1;
	}
	public void Restart()
	{   
		
		Application.LoadLevel(Application.loadedLevel);
		Time.timeScale = 1; 

		}

	public void Resume()
	{
		Time.timeScale = 1;

		/*mainPanel.SetActive(false);
		vidPanel.SetActive(false);
		audioPanel.SetActive(false);
		TitleTexts.SetActive(false);
		mask.SetActive(false);*/
	
	}
	public void quitOptions()
	{
		vidPanel.SetActive(false);
		audioPanel.SetActive(false);

	}
	public void quitGame()
	{
		Application.Quit();
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#endif
	
	}


	public void returnToMenu()
	{
		SceneManager.LoadScene (0);
	}

	public void Update()
	{
		/*if (vidPanel.active == true)
		{
			pauseMenu.text = "Video Menu";
		}
		else if (audioPanel.active == true)
		{
			pauseMenu.text = "Audio Menu";
		}
		else if (mainPanel.active == true)
		{
			pauseMenu.text = "Pause Menu";
		}*/

		if (Input.GetKeyDown(KeyCode.Escape) && mainPanel.active == false)
		{   mainPanel.SetActive(true);
		/*	vidPanel.SetActive(false);
			audioPanel.SetActive(false);
			TitleTexts.SetActive(true);
			mask.SetActive(true);*/
			Time.timeScale = 0;
			
		}
		else if(Input.GetKeyDown(KeyCode.Escape) && mainPanel.active == true) {
			Time.timeScale = 1f;
			/*mainPanel.SetActive(false);
			/*vidPanel.SetActive(false);
			audioPanel.SetActive(false);
			TitleTexts.SetActive(false);
			mask.SetActive(false);*/
			
		}



	}
	
}

