using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class choose : MonoBehaviour
{
	public static int num;
	public RCC_CarControllerV3 [] car;
	public GameObject trans;
	public GameObject otherUIElement;
	public GameObject[] otherUIElements;
	private int mult;

	private GameObject carCamera;
	void Start () {
		mult=SceneManager.GetActiveScene().buildIndex; 
		for (int i = 0; i < otherUIElements.Length; i++)
		{
			otherUIElements[i].gameObject.SetActive(false);
		}
	}
	public void Choose(int n){
		if (PlayerPrefs.GetInt ("score") < n * 1000)
			return;
		num = n;
		GameObject.FindObjectOfType<RCC_Camera> ().SetPlayerCar (car [n].gameObject);

		for (int i = 0; i < 5; i++) {
			if (n == i) {
				car [i].gameObject.GetComponent<RCC_CarControllerV3> ().steerHelperStrength =.55f ;	
				/*car [i].gameObject.GetComponent<RCC_CarControllerV3> ().tractionHelperStrength = .1f;
				car [i].gameObject.GetComponent<RCC_CarControllerV3> ().TCS = true;
				car [i].gameObject.GetComponent<RCC_CarControllerV3> ().TCSThreshold = .5f;
				car [i].gameObject.GetComponent<RCC_CarControllerV3> ().TCSStrength = 1f;*/
				continue;
			}
			car [i].gameObject.AddComponent<RCC_AICarController> ();
			car [i].gameObject.GetComponent<RCC_AICarController> ().wideRayLength = 30;
			car [i].gameObject.GetComponent<RCC_AICarController> ().tightRayLength = 50;
			car [i].gameObject.GetComponent<RCC_AICarController> ().limitSpeed =true;
			car [i].gameObject.GetComponent<RCC_CarControllerV3> ().steerHelperStrength += 0.05f*(mult-1)+0.015f*i;
			car [i].gameObject.GetComponent<RCC_AICarController> ().maximumSpeed = 150+(mult-1)*18;
			car [i].gameObject.GetComponent<RCC_AICarController> ().nextWaypointPassRadius = 30;
		}
		car [0].gameObject.transform.position = car [n].gameObject.transform.position;
		car [n].gameObject.transform.position = trans.transform.position;
		for (int i = 0; i < otherUIElements.Length; i++) {
			otherUIElements [i].gameObject.SetActive (true);
		}

		otherUIElement.gameObject.SetActive (false);
  
	}

}

