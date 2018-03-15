using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Debug_Controller))]
public class Debug_CustomInspector : Editor {

	public override void OnInspectorGUI () 
	{
		Debug_Controller thisTarget = (Debug_Controller)target;

		EditorGUILayout.HelpBox ("Press the button to toggle Debug Mode", MessageType.Info);


		if (GUILayout.Button("Toggle Debug Mode"))
		{
			thisTarget.IsInDebugMode = !thisTarget.IsInDebugMode;
		}

		EditorGUILayout.LabelField("In Debug Mode: ", thisTarget.IsInDebugMode.ToString() );
	}

}
