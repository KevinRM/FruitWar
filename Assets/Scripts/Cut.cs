﻿using UnityEngine;
using System.Collections;

public class Cut : MonoBehaviour {
	public Material capMaterial;
	private GameObject[] pieces;
	private GameObject victim;

	void OnTriggerEnter (Collider objeto) {
		gameObject.GetComponentInParent<Rigidbody> ().isKinematic = true;
		victim = objeto.gameObject;

		// Cortar el elemento con el que se colisionado si es una fruta
		if (victim.tag.Equals("Fruit") /*&& victim.GetComponent<SwordHit>().isCutting*/) {
			if (!victim.name.Equals("left side")) {
				GoalChecker.checkFruit (victim.name);
			}

			pieces = BLINDED_AM_ME.MeshCut.Cut (victim, transform.position, transform.up, capMaterial);
			if (!pieces [1].GetComponent<Rigidbody> ()) {
				pieces [1].AddComponent<Rigidbody> ();
			}

			if (!pieces [0].GetComponent<Rigidbody> ()) {
				pieces [0].AddComponent<Rigidbody> ();
			}
			pieces [0].GetComponent<Rigidbody> ().useGravity = true;
			pieces [0].GetComponent<FruitBehaviour>().cutted = true;
			pieces [1].GetComponent<Rigidbody> ().useGravity = true;
			pieces [1].AddComponent<SphereCollider> ();

			//victim.GetComponent<SwordHit> ().isCutting = false;
			Invoke ("destroyPart", 5f);
		}
	}

	private void destroyPart() {
		Destroy (pieces [1]);
	}
}
