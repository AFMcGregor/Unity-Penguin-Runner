using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerabacks : MonoBehaviour {

	public ObjectPooler[] backgroundPoolers;
	private float[] differentDistancesScales;
	public float smoothing;

	private Vector3 previousCameraPosition;

	// Use this for initialization
	void Start () {
		previousCameraPosition = transform.position;
		differentDistancesScales = new float[backgroundPoolers.Length];
		for (int i = 0; i < differentDistancesScales.Length; i++) {
			differentDistancesScales [i] = backgroundPoolers [i].transform.position.z * -1;
		}
	}
	
	// Update is called once per frame
	void LateUpdate () {
		for (int i=0;i<backgroundPoolers.Length;i++){
			Vector3 parallax = (previousCameraPosition-transform.position)*(differentDistancesScales[i]/smoothing);
			backgroundPoolers[i].transform.position=new Vector3(backgroundPoolers[i].transform.position.x+parallax.x,backgroundPoolers[i].transform.position.y+parallax.y,backgroundPoolers[i].transform.position.z);
		}
		previousCameraPosition=transform.position;
	}
}
