using UnityEngine;
using System.Collections;

public class createMap : MonoBehaviour {

	public GameObject stage1;
	public GameObject stage2;

	public int border = 50;

	void Update (){

		if (transform.position.z > border) {
			CreateMap ();
		}
	}

	void CreateMap(){
		if (stage1.transform.position.z < border) {
			border += 100;
			Vector3 temp = new Vector3 (0,-0.5f,border+50);
			stage1.transform.position = temp;
		} else if (stage2.transform.position.z < border) {
			border += 100;
			Vector3 temp = new Vector3 (0,-0.5f,border+50);
			stage2.transform.position = temp;
		}
	}
}
