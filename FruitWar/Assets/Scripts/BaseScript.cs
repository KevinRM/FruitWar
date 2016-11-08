using UnityEngine;
using System.Collections;

public class BaseScript : MonoBehaviour {
	private GameObject[] fruits;
	private bool haveFruit = false;

	void Start() {
		fruits = GameObject.Find ("ScriptsContainer").GetComponent<RandomFruitsGenerator> ().getFruits ();
	}

	void Update () {
		if(!haveFruit) {
			haveFruit = true;

			GameObject newFruit;
			int rndFruitIndex;
			rndFruitIndex = Random.Range (0, fruits.Length);
			newFruit = (GameObject) Object.Instantiate (fruits [rndFruitIndex], transform.position, Quaternion.identity);

			// Adding the position
			newFruit.GetComponent<FruitBehaviour> ().setFruitBaseAttached (gameObject);
		}
	}

	public void setNoFruit() {
		haveFruit = false;
	}
}
