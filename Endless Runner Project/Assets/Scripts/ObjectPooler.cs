using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class ObjectPooler : MonoBehaviour {
	
	List<GameObject> grounds;

	public GameObject oneground;

	public int listNumber;


	// Use this for initialization
	void Start () {
		grounds = new List<GameObject> ();
		for (int i = 0; i < listNumber; i++) {
			GameObject listOneGround = (GameObject)Instantiate (oneground);
			listOneGround.SetActive (false);
			grounds.Add (listOneGround);
		}
	}
	
	public GameObject objectPooler(){

		for (int i = 0; i < grounds.Count; i++) {
			if (!grounds[i].activeInHierarchy)
			{
				return grounds[i];

			}
		}
		
		GameObject listOneGround = (GameObject)Instantiate (oneground);
		listOneGround.SetActive (false);
		grounds.Add (listOneGround);
		return listOneGround;
	}

}
