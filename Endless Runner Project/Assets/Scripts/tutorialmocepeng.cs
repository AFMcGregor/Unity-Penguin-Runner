using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorialmocepeng : MonoBehaviour {
	public Transform moveplace;
	public Transform putPlace;
	public GameObject[] aCoin;
	public GameObject[] iceCream;
	public GameObject[] Hat;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		for (int i = 0; i < iceCream.Length; i++) {
			if (transform.position.x > iceCream [i].transform.position.x) {
				iceCream [i].transform.position = new Vector3 (iceCream [i].transform.position.x + 15, iceCream[i].transform.position.y, iceCream[i].transform.position.z);
			}
		}

		for (int i = 0; i < aCoin.Length; i++) {
			if (/*transform.position.x > aCoin [i].transform.position.x - 15 && */transform.position.x > aCoin [i].transform.position.x+1) {
				Debug.Log ("wokr");
				aCoin [i].transform.position = new Vector3 (aCoin [i].transform.position.x + 15, aCoin [i].transform.position.y, aCoin [i].transform.position.z);
			}
		}
		if (transform.position.x > moveplace.position.x) {
			if (SceneManager.GetActiveScene ().buildIndex == 0) {
				transform.position = new Vector3 (putPlace.position.x, putPlace.position.y, transform.position.z);
			} else {
				transform.position = new Vector3 (putPlace.position.x, transform.position.y, transform.position.z);
			}
			for (int i = 0; i < aCoin.Length; i++) {
						
				aCoin [i].transform.position = new Vector3 (aCoin [i].transform.position.x - 15, aCoin [i].transform.position.y, aCoin [i].transform.position.z);
			}
			for (int i = 0; i < iceCream.Length; i++) {
				iceCream [i].transform.position = new Vector3 (iceCream [i].transform.position.x - 15, iceCream [i].transform.position.y, iceCream [i].transform.position.z);
			}
			for (int i = 0; i < Hat.Length; i++) {
				Vector3 hatPosition = new Vector3 (transform.position.x + 5, transform.position.y+1, transform.position.z);
				Instantiate (Hat [i], hatPosition, transform.rotation);
			}
		}
}
}


		


