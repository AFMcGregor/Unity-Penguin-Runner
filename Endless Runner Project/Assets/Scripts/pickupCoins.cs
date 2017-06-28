using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupCoins : MonoBehaviour {

	private ScoreManager1 thescoreManager;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		thescoreManager = FindObjectOfType<ScoreManager1> ();
	}

	void OnTriggerEnter2D(Collider2D other){
		
	}


}

