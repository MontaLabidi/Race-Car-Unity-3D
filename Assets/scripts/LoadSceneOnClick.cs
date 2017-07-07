using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LoadSceneOnClick : MonoBehaviour {
	  public EventSystem uiEventSystem;
	public GameObject defualtSelectedMain;
	public void LoadByIndex(int sceneIndex)
	{
		SceneManager.LoadScene (sceneIndex);
		Time.timeScale = 1;
		uiEventSystem.firstSelectedGameObject = defualtSelectedMain;

	}
}