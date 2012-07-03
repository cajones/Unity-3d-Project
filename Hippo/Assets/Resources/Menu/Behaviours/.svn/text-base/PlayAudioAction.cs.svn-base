using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider))]
public class PlayAudioAction : MonoBehaviour 
{
	public AudioClip Audio;
	public AudioSource Speaker;
	
	public void OnMouseDown()
	{
		Speaker.PlayOneShot(Audio);
	}
}
