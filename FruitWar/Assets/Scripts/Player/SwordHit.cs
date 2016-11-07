using UnityEngine;
using System.Collections;

public class SwordHit : MonoBehaviour {
	public bool isCutting = false;
	public void hit() {
		isCutting = true;
		GameObject.Find ("Hand").GetComponent<Animation> ().Play ();
		Invoke ("noCutting", 1f);
	}
	private void noCutting(){
		isCutting = false;
	}
}
