using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watermoving : MonoBehaviour {

	private Rigidbody2D rig;
	public float speed;

	// Use this for initialization
	void Start () {
		rig=GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		rig.velocity=new Vector2(speed, 0);
	}
}
