using UnityEngine;
using System.Collections;

public class HitBoxManager : MonoBehaviour {

	private GameObject myMainCamera;

	void Start() {
		myMainCamera = GameObject.FindWithTag ("MainCamera");
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("Collision trigger detected.");
		if (other.tag=="hurtbox") {
			Debug.Log ("Hitbox collided with hurtbox, commencing shake.");
			myMainCamera.GetComponent<Shake>().ShakeMainCamera(0.1f, 0.01f, 1);
		}
	}
}
