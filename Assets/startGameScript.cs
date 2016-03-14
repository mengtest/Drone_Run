using UnityEngine;
using System.Collections;

public class startGameScript : MonoBehaviour {


	public void PlayScene(){
		Application.LoadLevel("playScene");
	}

	// Use this for initialization
	void Start () {
		Time.timeScale = 1f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
