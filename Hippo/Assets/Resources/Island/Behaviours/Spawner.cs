using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public int Amount;
	
	public float Delay;
	
	public float ScatterForce;
	
	public GameObject Prefab;
	
	private int _current;
	
	void Start() {
		StartCoroutine("Spawn");
	}
	
	IEnumerator Spawn()	{
		while(_current < Amount)
		{
			var clone = (GameObject)Instantiate(Prefab, this.transform.position, Random.rotation);
			_current++;
				
			if(clone != null && clone.rigidbody != null)
				clone.rigidbody.AddForce(clone.transform.forward * ScatterForce, ForceMode.Impulse);
			
			yield return new WaitForSeconds(Delay);
		}
	}
}
