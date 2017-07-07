using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class reload : MonoBehaviour {

	public void RestartScene(){

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

	}
}
