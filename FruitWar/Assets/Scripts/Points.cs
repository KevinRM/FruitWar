using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Points : MonoBehaviour {
	private const int NPOINTS_RIGHT_FRUIT = 200;
	private const int NPOINTS_WRONG_FRUIT = -50;
	private int numberPoints = 0;

	public void incrementPoints() {
		numberPoints += NPOINTS_RIGHT_FRUIT;
		updatePointsLabel ();
	}

	public void decrementPoints() {
		numberPoints += NPOINTS_WRONG_FRUIT;
		updatePointsLabel ();
	}

	public void resetPoints() {
		numberPoints = 0;
		updatePointsLabel ();
	}

	/**
	 * Añadido el 27/10/2016 teguayco
	 */
	public void updatePointsLabel() {
		GetComponent<Text> ().text = numberPoints + " pts";
	}
}
