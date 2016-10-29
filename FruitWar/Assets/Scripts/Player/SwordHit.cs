using UnityEngine;
using System.Collections;

public class SwordHit : MonoBehaviour {
	public void hit() {
		GameObject.Find ("Hand").GetComponent<Animation> ().Play ();
	}
}
