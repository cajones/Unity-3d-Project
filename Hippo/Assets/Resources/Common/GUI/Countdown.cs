using UnityEngine;
using System.Collections;
using System;
using System.Diagnostics;

public class Countdown : MonoBehaviour
{
    private const int boxWidth = 200;
    private Stopwatch stopwatch;
    public int countDown;

    void Awake()
    {
        stopwatch = new Stopwatch();
        stopwatch.Start();
    }

    public void OnGUI()
    {
        int elapsed = (countDown - stopwatch.Elapsed.Seconds);

        GUI.enabled = true;
        GUILayout.BeginArea(new Rect(150, 10, 200, 500));
        GUILayout.BeginHorizontal();

        GUILayout.Box("Countdown: " + elapsed, GUILayout.Width(boxWidth));

        GUILayout.EndHorizontal();
        GUILayout.EndArea();


        if(elapsed <= 198)
        {
            GUILayout.BeginArea(new Rect(500, 500, 300, 500));
            GUILayout.BeginHorizontal();

            GUILayout.Box("Game Over: " + elapsed, GUILayout.Width(boxWidth), GUILayout.Height(300));

            GUILayout.EndHorizontal();
            GUILayout.EndArea();
        }
    }


}
