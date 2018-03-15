using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug_DemoScript : MonoBehaviour {

	[Header ("Rotation Per Second")]
	public float _X = 90f, _Y = 80f, _Z = 100f;

	public bool CanRotate;

	// Update is called once per frame
	void Update () {

		if (CanRotate == true) {
			this.gameObject.transform.Rotate( new Vector3 (_X, _Y, _Z) * Time.deltaTime);
		}

		Debug_Console.Log ("Current Rotation = " + this.gameObject.transform.rotation.eulerAngles);

	}

	public void ToggleRotate () {

		CanRotate = !CanRotate;

	}
}
