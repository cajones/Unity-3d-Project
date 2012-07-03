using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Scoring : MonoBehaviour 
{
    private const int boxWidth = 80;
    private const int area = 20;
	
	private Hippo[] _hippos;
	
	void Awake() {
		_hippos = new GameRepository().Get().Hippos;
	}
	

    public void OnGUI()
    {
        GUI.enabled = true;
        GUILayout.BeginArea(new Rect(10, 10, 200, 500));
        GUILayout.BeginHorizontal();

        GUILayout.Box("Score", GUILayout.Width(boxWidth));

        GUILayout.EndHorizontal();
		
		for(var i = 0; i < _hippos.Length; i++) {
			AddPlayer(String.Format("{0} : {1}", _hippos[i].Identity, _hippos[i].BallsEaten));
		}
		
        GUILayout.EndArea();
    }

    public static void AddPlayer(string text)
    {
        GUILayout.BeginHorizontal();

        GUILayout.Box(text, GUILayout.Width(boxWidth));

		GUILayout.EndHorizontal();
    }
}
