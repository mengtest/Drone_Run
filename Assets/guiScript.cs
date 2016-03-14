using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class guiScript : MonoBehaviour {
	public Text text;
	public GameObject target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 vec = target.transform.position;
		float sc = vec.z + 47;
		int sco = (int)sc;
		text.text = "Score：" + sco;
	
	}
}
