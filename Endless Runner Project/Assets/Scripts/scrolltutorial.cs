using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolltutorial : MonoBehaviour {

	public GameObject t1;
	public Transform t2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0) && (Input.GetTouch(0).position.x<Screen.width/6)){
			if (Input.GetTouch (0).position.y > Screen.height / 2 && transform.position.y <= t1.transform.position.y) {
				transform.position = new Vector3 (transform.position.x, transform.position.y + 1, transform.position.z);
			} else {
				if (Input.GetTouch (0).position.y <= Screen.height / 2 && transform.position.y > t2.transform.position.y) {
					transform.position = new Vector3 (transform.position.x, transform.position.y - 1, transform.position.z);
				}
			}
			
		}
	}

	void Scrolldown(){
		transform.position = new Vector3 (transform.position.x, transform.position.y - 1, transform.position.z);
			}
}
