using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viker_Debug_Controller : MonoBehaviour {

	private bool InDebugMode;

	public bool IsInDebugMode {

		get{
			return InDebugMode;
		}
		set{
			InDebugMode = value;
			UpdateDebugObjects ();
		}

	}

	public static Viker_Debug_Controller instance;

	void Awake () {

		if (instance == null) {
			instance = this;

			InDebugMode = false;

			return;
		}

		Destroy (this);

	}

	void OnGUI () {

		if (IsInDebugMode == true) {
			GUI.Label(new Rect(10, 10, 100, 20), "Debug Mode!");
		}

	}

	public void UpdateDebugObjects () {

		Viker_Debug_Object[] debugObjects = FindObjectsOfType ( typeof(Viker_Debug_Object) ) as Viker_Debug_Object[];

		Debug.Log ("Updating " + debugObjects.Length + " debug objects");
	
		foreach (Viker_Debug_Object obj in debugObjects) {

			obj.SetVisible (IsInDebugMode);

		}
	}

}
