using UnityEngine;
using System.Collections;

public class Shake : MonoBehaviour {

	private float shakeIntensity=0;
	private float shakeDecay=0;
	private Vector3 realPosition;
	private Transform myTransform;
	private bool shaking=false;
	private float slowdownFactor = 0;

	void Start() {
		myTransform = GetComponent<Transform> ();
	}
	// Update is called once per frame
	void Update () {
		if (shaking) {
			myTransform.position=realPosition+Random.insideUnitSphere * shakeIntensity;
			shakeIntensity-=shakeDecay;
			Time.timeScale=1-slowdownFactor;
			if(shakeIntensity<=0) {
				shaking=false;
				myTransform.position=realPosition;
				Time.timeScale=1;
			}
		}
	}

	public void ShakeMainCamera(float newIntensity, float newDecay, float newSlowdownFactor=0) {
		realPosition = myTransform.position;
		shakeIntensity = newIntensity;
		shakeDecay = newDecay;
		shaking = true;
		slowdownFactor = newSlowdownFactor;
	}
}
