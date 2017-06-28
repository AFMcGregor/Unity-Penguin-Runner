using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour {

	public GameObject dp;


	// Use this for initialization
	void Start () {
		dp= GameObject.Find ("dp");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < dp.transform.position.x) {

			gameObject.SetActive (false);

		}
	}
}
