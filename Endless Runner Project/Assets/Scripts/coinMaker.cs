using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinMaker : MonoBehaviour {

	public ObjectPooler coinPoolers;

	public void MakeCoins3(Vector3 coinPosition){
		GameObject coin = coinPoolers.objectPooler();
		coin.transform.position = new Vector3 (coinPosition.x, coinPosition.y + 2, coinPosition.z);
		coin.SetActive(true);
		GameObject coin1 = coinPoolers.objectPooler();
		coin1.transform.position = new Vector3 (coinPosition.x - 2, coinPosition.y + 1, coinPosition.z);
		coin1.SetActive(true);
		GameObject coin2 = coinPoolers.objectPooler();
		coin2.transform.position = new Vector3 (coinPosition.x + 2, coinPosition.y + 1, coinPosition.z);
		coin2.SetActive(true);
	}

	public void MakeCoins8(Vector3 coinPosition){
		GameObject coin = coinPoolers.objectPooler();
		coin.transform.position = new Vector3 (coinPosition.x, coinPosition.y+2, coinPosition.z);
		coin.SetActive(true);
		GameObject coin7 = coinPoolers.objectPooler();
		coin7.transform.position = new Vector3 (coinPosition.x+4, coinPosition.y, coinPosition.z);
		coin7.SetActive(true);
		GameObject coin1 = coinPoolers.objectPooler();
		coin1.transform.position = new Vector3 (coinPosition.x - 1, coinPosition.y+1, coinPosition.z);
		coin1.SetActive(true);
		GameObject coin2 = coinPoolers.objectPooler();
		coin2.transform.position = new Vector3 (coinPosition.x + 1, coinPosition.y+2, coinPosition.z);
		coin2.SetActive(true);
		GameObject coin3 = coinPoolers.objectPooler();
		coin3.transform.position = new Vector3 (coinPosition.x - 2, coinPosition.y, coinPosition.z);
		coin3.SetActive(true);
		GameObject coin4 = coinPoolers.objectPooler();
		coin4.transform.position = new Vector3 (coinPosition.x + 2, coinPosition.y+1, coinPosition.z);
		coin4.SetActive(true);
		GameObject coin5 = coinPoolers.objectPooler();
		coin5.transform.position = new Vector3 (coinPosition.x - 3, coinPosition.y, coinPosition.z);
		coin5.SetActive(true);
		GameObject coin6 = coinPoolers.objectPooler();
		coin6.transform.position = new Vector3 (coinPosition.x + 3, coinPosition.y, coinPosition.z);
		coin6.SetActive(true);
	}

	public void MakeCoins3flat(Vector3 coinPosition){
		GameObject coin = coinPoolers.objectPooler();
		coin.transform.position = new Vector3 (coinPosition.x, coinPosition.y+2, coinPosition.z);
		coin.SetActive(true);
		GameObject coin7 = coinPoolers.objectPooler();
		coin7.transform.position = new Vector3 (coinPosition.x-1, coinPosition.y+2, coinPosition.z);
		coin7.SetActive(true);
		GameObject coin1 = coinPoolers.objectPooler();
		coin1.transform.position = new Vector3 (coinPosition.x+1, coinPosition.y+2, coinPosition.z);
		coin1.SetActive(true);
	}

	public void MakeCoins3endflyup(Vector3 coinPosition){
		GameObject coin = coinPoolers.objectPooler();
		coin.transform.position = new Vector3 (coinPosition.x-4, coinPosition.y-1, coinPosition.z);
		coin.SetActive(true);
		GameObject coin7 = coinPoolers.objectPooler();
		coin7.transform.position = new Vector3 (coinPosition.x-3, coinPosition.y, coinPosition.z);
		coin7.SetActive(true);
		GameObject coin1 = coinPoolers.objectPooler();
		coin1.transform.position = new Vector3 (coinPosition.x-2, coinPosition.y+1, coinPosition.z);
		coin1.SetActive(true);
	}

	public void MakeCoins3endflydown(Vector3 coinPosition){
		GameObject coin = coinPoolers.objectPooler();
		coin.transform.position = new Vector3 (coinPosition.x+1, coinPosition.y, coinPosition.z);
		coin.SetActive(true);
		GameObject coin7 = coinPoolers.objectPooler();
		coin7.transform.position = new Vector3 (coinPosition.x, coinPosition.y+1, coinPosition.z);
		coin7.SetActive(true);
		GameObject coin1 = coinPoolers.objectPooler();
		coin1.transform.position = new Vector3 (coinPosition.x-1, coinPosition.y+2, coinPosition.z);
		coin1.SetActive(true);
	}






}
