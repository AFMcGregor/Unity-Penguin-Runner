using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundPoolers : MonoBehaviour {

	public ObjectPooler[] backgroundPool;
	private float[] poolWidths;
	private Rigidbody2D[] rigids;
	private float velX;
	public Camera mainCamera;
	private float speed;

	void Start(){
		speed = 10f;
		velX = 100f;
		poolWidths= new float[backgroundPool.Length];
		for (int i = 0; i < backgroundPool.Length; i++) {
			poolWidths [i] = backgroundPool [i].oneground.GetComponent<BoxCollider2D> ().size.x;
				//backgroundPool[i].oneground.GetComponent<BoxCollider2D> ().size.x;
		}
		/*rigids = new Rigidbody2D[backgroundPool.Length];
		for (int i = 0; i < backgroundPool.Length; i++) {
			rigids [i] = backgroundPool [i].oneground.GetComponent<Rigidbody2D> ();
		}*/
	}



	/*public void backPool(Vector3 coinPosition){
		for (int i = 0; i < backgroundPool.Length; i++) {
			GameObject wall = backgroundPool [i].objectPooler ();

			wall.transform.position = new Vector3 (coinPosition.x, 0f, backgroundPool[i].oneground.transform.position.z);
			//rigids [i].velocity = new Vector2 (velX, 0);
			wall.SetActive (true);
		}
	}*/
}
