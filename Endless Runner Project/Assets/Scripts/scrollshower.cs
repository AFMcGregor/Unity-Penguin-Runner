using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrollshower : MonoBehaviour {

	public Camera maincam;
	public Image downArrow;
	public Image upArrow;
	public Transform t1;
	public Transform t2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (maincam.transform.position.y > t2.transform.position.y + 5) {
			downArrow.enabled = true;
		} else {
			downArrow.enabled = false;
		}
		if (maincam.transform.position.y < t1.transform.position.y - 5) {
			upArrow.enabled = true;
		} else {
			upArrow.enabled = false;
		}
	}
}
