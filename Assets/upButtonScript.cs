using UnityEngine;
using System.Collections;

public class upButtonScript : MonoBehaviour {
	public GameObject target;
	bool push = false;

	// Use this for initialization
	void Start () {}

	public void PushDown(){
		push = true;
	}

	public void PushUp(){
		push = false;
	}

	void Update(){
		if (push) {
			UpOnClick();
		}
	}

	public void UpOnClick(){
	//	Rigidbody rigidbody = GetComponent<Rigidbody> ();
	//	target.GetComponent<Rigidbody>().AddForce (0, 15f, 0);
		target.transform.rotation = Quaternion.Euler (20f, 0f,0f);
		target.transform.Translate (0.0f, 0.25f, 0.0f);
	}
}
