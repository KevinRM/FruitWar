using UnityEngine;
using System.Collections;

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
}
