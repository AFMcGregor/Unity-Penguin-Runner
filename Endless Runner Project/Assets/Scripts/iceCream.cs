using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceCream : MonoBehaviour {

	public ObjectPooler coinPoolers;

	public void MakeIceCreams(Vector3 iceCreamPosition){
		GameObject iceCream = coinPoolers.objectPooler();
		iceCream.transform.position = iceCreamPosition;
		iceCream.SetActive(true);
	}

}
