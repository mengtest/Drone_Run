using UnityEngine;
using System.Collections;

//target(ドローン)を追従

public class CameraScript : MonoBehaviour {
	public Transform target;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
		Vector3 vec = target.position;
		Vector3 fvec = target.forward;
		fvec *= 4f;
		fvec.y = -1f;
		Camera.main.transform.position = vec - fvec;
		Camera.main.transform.LookAt (vec);
	}
}
