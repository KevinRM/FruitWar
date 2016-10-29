using UnityEngine;
using System.Collections;

public class Cut : MonoBehaviour {
	public Material capMaterial;

	void OnTriggerEnter (Collider objeto){
		GameObject victim = objeto.gameObject;

		// Cortar el elemento con el que se colisionado si es una fruta
		if (victim.tag.Equals("Fruit")) {
			victim.GetComponent<Rigidbody> ().useGravity = true;

			// Comprobar si la fruta cortada es el objetivo
			if (!victim.name.Equals("left side")) {
				GoalChecker.checkFruit (victim.name);
			}

			GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut (victim, transform.position, transform.right, capMaterial);
			if (!pieces [1].GetComponent<Rigidbody> ()) {
				pieces [1].AddComponent<Rigidbody> ();
			}

			Destroy (pieces [1], 1);
		}
	}
}
