﻿using UnityEngine;
using System.Collections;

public class SwordHit : MonoBehaviour {
	//public bool isCutting = false;
	public void hit() {
		//isCutting = true;
		//GameObject.Find ("Hand").GetComponentInChildren <Rigidbody>().isKinematic = true;
		//GameObject.Find ("Hand").GetComponent<Animation> ().Play(animation:"Sword_hit3");
		//Invoke ("noCutting", 1f);
	}

	private void noCutting(){
		//isCutting = false;
		//GameObject.Find ("Hand").GetComponentInChildren <Rigidbody>().isKinematic = false;
	}
}
