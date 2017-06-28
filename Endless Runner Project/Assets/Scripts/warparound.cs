using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warparound : MonoBehaviour {
	public Transform moveplace;
	public Transform putPlace;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x<moveplace.position.x){
			transform.position = new Vector3 (putPlace.position.x, transform.position.y, transform.position.z);
	}
}
}
