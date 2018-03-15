using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug_Controller : MonoBehaviour {

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

	public static Debug_Controller instance;

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

		Debug_Object[] debugObjects = FindObjectsOfType ( typeof(Debug_Object) ) as Viker_Debug_Object[];

		Debug.Log ("Updating " + debugObjects.Length + " debug objects");
	
		foreach (Debug_Object obj in debugObjects) {

			obj.SetVisible (IsInDebugMode);

		}
	}

}
