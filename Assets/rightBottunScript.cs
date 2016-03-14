using UnityEngine;
using System.Collections;

public class rightBottunScript : MonoBehaviour {
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
			RightOnClick();
		}
	}

	public void RightOnClick(){
	//	Rigidbody rigidbody = GetComponent<Rigidbody> ();
	//	target.GetComponent<Rigidbody>().AddForce (15f, 0, 0);
		target.transform.rotation = Quaternion.Euler (20f, 0f, -20f);
		target.transform.Translate (0.25f, 0.095f, 0.0f);
	}
}
