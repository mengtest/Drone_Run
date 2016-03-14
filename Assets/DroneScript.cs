using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Advertisements;

public class DroneScript : MonoBehaviour {
	public GameObject panel;
	AudioSource audio1;

	void Awake()
	{   
		//ios用ゲームID
		Advertisement.Initialize ("*******");
	}

	// Use this for initialization
	void Start () {
		audio1 = gameObject.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");

		Rigidbody rigidbody = GetComponent<Rigidbody> ();

		//ドローン操作
		float y = 0.5f * Time.deltaTime;
		rigidbody.AddForce (x * 0.8f, z * 0.8f , y, ForceMode.Impulse);
		

		//移動範囲を制限
		transform.position = (new Vector3 (Mathf.Clamp (transform.position.x, -2.6f, 3f), 
			Mathf.Clamp (transform.position.y, 0.2f, 3f), transform.position.z));

		transform.rotation = Quaternion.Euler (20f, 0, 0);
	}
	
		//衝突時のアクション
	void  OnCollisionEnter(Collision collision){
		Rigidbody rigidbody = GetComponent<Rigidbody> ();
		if (collision.gameObject.name != "drone") {
			rigidbody.velocity = Vector3.zero;
			rigidbody.AddForce (0, -10f, 0, ForceMode.Impulse);
			audio1.Play ();
			Invoke ("DelayMethod", 1f);
		}
	}

		void DelayMethod(){
		ShowAd ();
			panel.transform.position = new Vector3(600f,300f,0);
			Vector3 vec = transform.position;
			float sc = vec.z + 47;
			Time.timeScale = 0;
	}

	public void ShowAd() {
		int var;
		var = Random.Range (1, 5);
		if (var == 2) {
			if (Advertisement.isReady ()) {
				Advertisement.Show ();
			}
		}
	}
}
