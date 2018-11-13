using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLock : MonoBehaviour {

	void Update(){
		Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;

		if (Time.timeScale == 0f) {
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
	}
}
