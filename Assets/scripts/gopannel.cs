using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gopannel : MonoBehaviour {
	public AudioSource audio1;
	public AudioSource audio3;
	public AudioSource audio2;

	public GameObject player1;
	public GameObject player2;
	public GameObject otherUIElement;
	public  Text golabel;
	public  GameObject []cars;
	public GameObject[] otherUIElements;
	private GameObject carCamera;
	void Start () {
		for (int i = 0; i < otherUIElements.Length; i++)
		{
			otherUIElements[i].gameObject.SetActive(false);
		}
		//GameObject.FindObjectOfType<RCC_Camera> ().SetPlayerCar (null);
		carCamera = GameObject.FindObjectOfType<RCC_Camera>().gameObject;
		player1.SetActive(true);
		carCamera.SetActive(false);
		player2.SetActive(false);

		for (int i = 0; i <cars.Length; i++) {			
			cars [i].GetComponent<RCC_CarControllerV3> ().canControl = false;
		}
		StartCoroutine(go ());
	}
	IEnumerator go (){
		
		golabel.text = "READY!";
		yield return new WaitForSeconds(1f);
		audio1.Play ();
		yield return new WaitForSeconds(1f);
		golabel.text = "SET!";

		player1.SetActive(false);
		player2.SetActive (true);
		yield return new WaitForSeconds(0.5f);
		audio3.Play ();
		yield return new WaitForSeconds(2f);
		player2.SetActive (false);
		carCamera.SetActive(true);
		golabel.text = "GO!";
		yield return new WaitForSeconds(0.5f);
		audio2.Play ();
		yield return new WaitForSeconds(1f);
		for (int i = 0; i < otherUIElements.Length; i++)
		{
			otherUIElements[i].gameObject.SetActive(true);
		}

		for (int i = 0; i <cars.Length; i++) {
			cars [i].GetComponent<RCC_CarControllerV3> ().canControl = true;
			if(!cars [i].GetComponent<RCC_AICarController>())
				GameObject.FindObjectOfType<RCC_DashboardInputs> ().GetVehicle (cars[i].GetComponent<RCC_CarControllerV3> ());
		}


		otherUIElement.gameObject.SetActive(false);
}
}