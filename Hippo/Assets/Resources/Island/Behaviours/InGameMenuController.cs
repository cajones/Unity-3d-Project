using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Transform))]
public class InGameMenuController : MonoBehaviour {
	private bool _isPaused = false;
	
	public int VerticalOffset = 20;
	
	void Update () {
		if( Input.GetKeyDown (KeyCode.Escape)) {
			ShowInGameMenu();
		}
	}
	
	void ShowInGameMenu () {
		_isPaused = !_isPaused;
		
		var offset = _isPaused ? Vector3.down * this.VerticalOffset : Vector3.up * this.VerticalOffset;
		this.transform.Translate(offset);
		
		Time.timeScale = _isPaused ? 0 :1 ;
	}
}
