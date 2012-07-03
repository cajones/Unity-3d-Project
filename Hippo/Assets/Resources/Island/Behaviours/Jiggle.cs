using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Transform))]
public class Jiggle : MonoBehaviour {
	
	
	private Transform transform;
	public float modulation = 0.025f;
	public float rate = 0.15f;
	// Use this for initialization
	void Start () {
		transform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeScale > 0)
		{
			var freq = Mathf.Sin(Time.time/rate);
			transform.Translate(0, (freq * modulation), 0, Space.Self); 
		}
	}
}
