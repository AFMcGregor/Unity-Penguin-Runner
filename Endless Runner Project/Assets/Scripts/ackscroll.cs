using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ackscroll : MonoBehaviour {
	
/*	public Transform makePoint;
	public GameObject hill;
	public float hillrigid;
	public GameObject originalPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x<makePoint.position.x){
			transform.position = new Vector3 (transform.position.x+hillrigid, originalPoint.transform.position.y, originalPoint.transform.position.z);
			Instantiate (hill, transform.position, transform.rotation);
	}
}
}*/


	public Transform makePoint;
	public ObjectPooler[] backgroundPoolers;
	private float[] differentDistancesScales;
	public float smoothing;
	public float[] hillrigid;
	public GameObject[] originalPoint;

	private Vector3 previousCameraPosition;

	// Use this for initialization
	void Start () {
		previousCameraPosition = transform.position;
		differentDistancesScales = new float[backgroundPoolers.Length];
		for (int i = 0; i < differentDistancesScales.Length; i++) {
			differentDistancesScales [i] = backgroundPoolers [i].transform.position.z * -1;
		}
	}
	/*
	void Update () {
		for (int i = 0; i < differentDistancesScales.Length; i++) {
			if (transform.position.x < makePoint.position.x) {
				//transform.position = new Vector3 (transform.position.x + hillrigid [i], transform.position.y, transform.position.z);
				Vector3 newPosMountains = new Vector3 (transform.position.x+hillrigid[i], originalPoint [i].transform.position.y, originalPoint [i].transform.position.z);
				Instantiate (backgroundPoolers[i].oneground, newPosMountains, backgroundPoolers[i].oneground.transform.rotation);
			}
		}
	}
*/
	// Update is called once per frame
	void LateUpdate () {
		for (int i=0;i<originalPoint.Length;i++){
			/*if (transform.position.x < makePoint.position.x) {
				//transform.position = new Vector3 (transform.position.x + hillrigid [i], transform.position.y, transform.position.z);
				Vector3 newPosMountains = new Vector3 (originalPoint[i].transform.position.x+hillrigid[i], originalPoint [i].transform.position.y, originalPoint [i].transform.position.z);
				Instantiate (backgroundPoolers[i].oneground, newPosMountains, backgroundPoolers[i].oneground.transform.rotation);
			}*/
			Vector3 parallax = (previousCameraPosition-transform.position)*(differentDistancesScales[i]/smoothing);
			backgroundPoolers[i].transform.position=new Vector3(backgroundPoolers[i].transform.position.x+parallax.x,backgroundPoolers[i].transform.position.y+parallax.y,originalPoint[i].transform.position.z);
		}
		previousCameraPosition=transform.position;
	}
}
