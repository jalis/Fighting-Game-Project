using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {

	private Animator myAnimator;
	private string currentAnimationState="idle";

	void Start() {
		myAnimator = GetComponent<Animator> ();
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Space)) {
			if( currentAnimationState=="idle"){
				myAnimator.Play ("ryu_punch");
			}
		}
	}
	public void setAnimationState(string newState) {
		currentAnimationState = newState;
		Debug.Log ("Current animation state: " + currentAnimationState);
	}
}
