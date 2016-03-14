using UnityEngine;
using System.Collections;

public class soundScript : MonoBehaviour {

	AudioSource sound2; //効果音用AudioSource
	public GameObject canvas;

	void Start () {
		sound2 = gameObject.GetComponent<AudioSource> ();
	}

	//BGMの再生
	void FixedUpdate () {
		Vector3 vec = canvas.transform.position;
		if (vec.x == 600f || vec.y == 300f) {
			sound2.Stop ();
		}
	}
}