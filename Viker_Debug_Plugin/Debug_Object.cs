using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Debug_Object : MonoBehaviour {


	//Ideas
	//1. adding a canvas group and setting alpha to 0
	//		you still make draw calls, so not ideal
	//2. disabling any visual components on the object and it's children
	//		For this, in the awake, go tthrough every child object and add a Viker_Debug_Object component
	//		More expensive at start, but saves iterating through children later
	//		Also saves on draw calls when debug mode is off

	private CanvasGroup thisCanvasGroup;

	void Awake () {

		//add a canvas group to the object, so it can be hidden

		thisCanvasGroup = this.gameObject.AddComponent ( typeof(CanvasGroup) ) as CanvasGroup;
		

	}

	void OnEnable () {

		SetVisible (Viker_Debug_Controller.instance.IsInDebugMode);

	}

	public void SetVisible (bool _visible) {

		if (_visible == true) {
			thisCanvasGroup.alpha = 1;
		} else {
			thisCanvasGroup.alpha = 0;
		}

	}

}
