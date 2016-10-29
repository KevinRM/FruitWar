using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/**
 * Script para el control del tiempo
 */
public class TimeChecker : MonoBehaviour {
	private float timeInSeconds;

	void Start () {
		timeInSeconds = 2000.0f;
		updateTimeLabel ();
	}
		
	void Update () {
		timeInSeconds -= Time.deltaTime;
		updateTimeLabel ();

		if (timeInSeconds <= 0) {
			Time.timeScale = 0;
			displayWarningTimeOut ();
		}
	}

	private void updateTimeLabel() {
		GetComponent<Text> ().text = (int) timeInSeconds + " sg";
	}

	private void displayWarningTimeOut() {
		//int points = -1;	// Recoger puntos conseguidos
		// Desplegando mensaje de fin de tiempo
	}
}
