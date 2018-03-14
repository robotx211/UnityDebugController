
using UnityEngine;
using System;

public static class Viker_Debug_Console {

	//used to not show general debug message on mobile


	public static void Log (String Message) {

		if (Viker_Debug_Controller.instance.IsInDebugMode == true) {
			Debug.Log ("Debug: " + Message);
		}

	}

	public static void Log (String Message, UnityEngine.Object Context = null) {

		if (Viker_Debug_Controller.instance.IsInDebugMode == true) {

			if (Context == null) {
				Debug.Log ("Debug: " + Message);
			} else {
				Debug.Log ("Debug: " + Message, Context);
			}

		}

	}



}
