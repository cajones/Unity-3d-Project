using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Renderer))]
public class DisappearOnFixedTime : MonoBehaviour {
	
	public int FixedTimeInSeconds;
	private Renderer renderer;
	public int Rate = 3;
	
	void Awake () {
		renderer = GetComponent<Renderer>();	
	}
	
	void Update () {
		if(Time.timeSinceLevelLoad >= FixedTimeInSeconds && Time.timeSinceLevelLoad <= FixedTimeInSeconds + Rate)
		{
			var delta = Mathf.InverseLerp(FixedTimeInSeconds, FixedTimeInSeconds+Rate, Time.timeSinceLevelLoad);
			var c = renderer.material.color;
			renderer.material.color = new Color(c.r, c.g, c.b, 1-delta);
		}
	}
}
