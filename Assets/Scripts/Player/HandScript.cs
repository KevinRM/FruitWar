using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class HandScript : MonoBehaviour {
	private Transform parentWeaponSelected;
	private Transform weapon;
	private Vector3 positionWeapon;
	private Quaternion rotationWeapon;
	private Vector3 scaleWeapon;

	public void chageWeapon(Transform parentWeapon) {
		if (parentWeaponSelected != null) {
			weapon.SetParent (parentWeaponSelected);
			weapon.localPosition = positionWeapon;
			weapon.localRotation = rotationWeapon;
			weapon.localScale = scaleWeapon;
		}
		parentWeaponSelected = parentWeapon;
		weapon = parentWeaponSelected.GetChild (0);
		positionWeapon = weapon.localPosition;
		rotationWeapon = weapon.localRotation;
		scaleWeapon = weapon.localScale;
		weapon.SetParent (transform);
		weapon.localPosition = positionWeapon;
		weapon.localRotation = rotationWeapon;
		weapon.localScale = scaleWeapon;
	}

	void FixedUpdate() {
		if (CrossPlatformInputManager.GetAxis ("Fire1") == 1) {
			playAnimation (0);
		}
		if (CrossPlatformInputManager.GetAxis ("Fire2") == 1) {
			playAnimation (1);
		}
		if (CrossPlatformInputManager.GetAxis ("Fire3") == 1) {
			playAnimation (2);
		}
	}

	private void playAnimation(int whatAnim) {
		switch (whatAnim) {
		case 0:
			{
				GetComponent<Animation> ().Play (animation: "Sword_hit");
				GetComponent<AudioSource> ().Play ();
			}
			break;
		case 1:
			{
				GetComponent<Animation> ().Play (animation: "Sword_hit2");
				GetComponent<AudioSource> ().Play ();
			}
			break;
		case 2:
			{
				GetComponent<Animation> ().Play (animation: "Sword_hit3");
				GetComponent<AudioSource> ().Play ();
			}
			break;
		}
	}
}
