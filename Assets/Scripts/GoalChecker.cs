using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoalChecker : MonoBehaviour {
	private static string[] fruitsNames = {"Apple", "Pineapple", "Kiwi", "Banana", "Orange", "Pear", "Watermelon"}; 
	private static string fruitGoalName;

	void Start () {
		setRandomFruitGoal ();
		updateFruitLabel ();
	}

	/**
	 * Establece una nueva fruta objetivo aleatoriamente
	 */
	private static void setRandomFruitGoal() {
		int rndFruitIndex = Random.Range (0, fruitsNames.Length);
		fruitGoalName = fruitsNames [rndFruitIndex];
		updateFruitLabel ();
	}

	/**
	 * Comprueba que la fruta cortada coincide con la fruta objetivo
	 */
	public static void checkFruit(string cutFruitName) {
		GameObject pointsLabel = GameObject.Find ("Points");
		cutFruitName = cutFruitName.Replace ("(Clone)", "");

		if (cutFruitName.Equals (fruitGoalName)) {
			pointsLabel.GetComponent<Points> ().incrementPoints ();
			// Cambiamos de objetivo en el caso de alcanzarlo
			setRandomFruitGoal ();
		} else {
			pointsLabel.GetComponent<Points> ().decrementPoints ();
		}
	}

	private static void updateFruitLabel() {
		GameObject goalLabel = GameObject.Find ("Goal");
		goalLabel.GetComponent<Text> ().text = fruitGoalName;
	}
}
