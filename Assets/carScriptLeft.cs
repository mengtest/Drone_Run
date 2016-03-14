using UnityEngine;
using System.Collections;

public class carScriptLeft : MonoBehaviour {
	public Transform target;

	// Use this for initialization
	void Start () {}

	// Update is called once per frame
	void FixedUpdate () {
		Rigidbody rigidbody = GetComponent<Rigidbody> ();
		Vector3 vec = target.position;
		Vector3 carVec = transform.position;

		float v = 0.1f;
		if (vec.z > 50) {
			v *= 2;
		}

		if (carVec.z > vec.z && carVec.z - vec.z < 5f && transform.position.x < 0f) {
			transform.Translate (new Vector3 (0, 0, v));
		} else if(carVec.z < vec.z &&  transform.position.x > -5f){
			rigidbody.velocity = Vector3.zero;
			transform.Translate (0, 0, v * -1);
		}
	}
}
