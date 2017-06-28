using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatPooler : MonoBehaviour {

	public ObjectPooler hatPoolers;

	public void MakeHats(Vector3 HatPosition){
		GameObject hat= hatPoolers.objectPooler();
		hat.transform.position = HatPosition;
		hat.SetActive(true);
	}
}
