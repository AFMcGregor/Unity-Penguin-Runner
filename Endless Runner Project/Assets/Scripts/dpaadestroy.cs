using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dpaadestroy : MonoBehaviour {

	public GameObject destroy;


	// Use this for initialization
	void Start () {
		destroy= GameObject.Find ("destroy");
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x < destroy.transform.position.x) {

			gameObject.SetActive (false);

		}
	}
}
