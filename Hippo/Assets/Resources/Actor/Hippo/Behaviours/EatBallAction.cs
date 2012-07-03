using UnityEngine;
using System.Collections;

public class EatBallAction : MonoBehaviour {

    public void OnCollisionEnter(Collision collision) {
        Debug.Log ("Collision");

        foreach (ContactPoint contact in collision.contacts) {
            GameObjectDestroy.Destroy(contact.otherCollider);            
        }
		SendMessageUpwards ("EatBall", 1);
    }
}
