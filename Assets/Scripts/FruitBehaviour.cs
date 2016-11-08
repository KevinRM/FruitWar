using UnityEngine;
using System.Collections;

/**
 * Script asociado a cada fruta de la casa
 */
public class FruitBehaviour : MonoBehaviour {
	public GameObject fruitBaseAttached;
	private bool colision = false;
	public bool cutted = false;
	public GameObject colisionador = null;

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
		colisionador = obj.gameObject;

		if(!colision) {
			colision = true;
			if (colisionador.tag == "Fruit") {
				Invoke ("destroyFruit", 3f);
			} else {
				Invoke ("destroyFruit", 10f);
			}
		}
	}

	public void destroyFruit() {
		fruitBaseAttached.GetComponent<BaseScript> ().setNoFruit ();
		Destroy (gameObject);
		if (colisionador.tag == "Fruit") {
			Destroy (colisionador);
		}
	}
}
