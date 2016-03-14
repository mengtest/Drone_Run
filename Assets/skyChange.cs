using UnityEngine;
using System.Collections;

public class skyChange : MonoBehaviour {
	public Material skybox;

	void Start()
	{
		// Skyboxを変更する
		RenderSettings.skybox = skybox;
	}
		
	
	// Update is called once per frame
	void Update () {}
}
