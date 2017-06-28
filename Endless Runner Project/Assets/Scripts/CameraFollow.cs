using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public PlayerControls thePlayer;

	private Vector3 initialPosition;
	private float distanceToMove;
	private AudioSource source;
	public AudioClip backgroundmusic;
	//public AudioClip scoredeathscreen;
	public GameObject peng;
	//private Rigidbody2D camvel;
	//private float vel;

	// Use this for initialization
	void Start () {
		//camvel = GetComponent<Rigidbody2D> ();
		source=GetComponent<AudioSource>();
	
		//source.PlayOneShot(backgroundmusic,0.7f);
		Screen.SetResolution ((int)Screen.width, (int)Screen.height, true);
		thePlayer = FindObjectOfType<PlayerControls> ();
		initialPosition = thePlayer.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (peng.activeInHierarchy == false) {
			//source.PlayOneShot (scoredeathscreen);
		}
		//vel = camvel.velocity.x;
		distanceToMove = thePlayer.transform.position.x-initialPosition.x;
		initialPosition = thePlayer.transform.position;
		transform.position = new Vector3 (transform.position.x + distanceToMove, transform.position.y, transform.position.z);
	}
}
