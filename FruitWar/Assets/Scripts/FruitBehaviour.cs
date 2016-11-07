using UnityEngine;
using System.Collections;

/**
 * Script asociado a cada fruta de la casa
 */
public class FruitBehaviour : MonoBehaviour {
	private GameObject fruitBaseAttached;
	private bool colision = false;
	public bool cutted = false;

	void Update () {
		if (!cutted) {
			gameObject.transform.Rotate (new Vector3 (0f, 1f, 0f) * 50 * Time.deltaTime);
		}
	}

	public void setFruitBaseAttached(GameObject aFruitBase) {
		fruitBaseAttached = aFruitBase;
	}

	public GameObject getBaseAttached() {
		return fruitBaseAttached;
	}

	void OnCollisionEnter(Collision obj) {
		if(!colision) {
			colision = true;
			Invoke ("destroyFruit", 3f);
		}
	}

	private void destroyFruit() {
		fruitBaseAttached.GetComponent<BaseScript> ().setNoFruit ();
		//Destroy (gameObject);
	}
}
