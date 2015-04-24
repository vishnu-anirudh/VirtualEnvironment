using UnityEngine;
using System.Collections;


public class PhoneLight : MonoBehaviour {
	//Note: presently it works when space is pressed in keyboard
	void Start() {

	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.Space)) {
			light.enabled=!light.enabled;
		}
	}
}
