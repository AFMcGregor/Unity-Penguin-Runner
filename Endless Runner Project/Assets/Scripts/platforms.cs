using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platforms : MonoBehaviour {

	public GameObject platform;
	public Transform platformGenerationPoint;
	public float distanceBetweenMin;
	public float distanceBetweenMax;
	public ObjectPooler[] objectPoolerScript;

	//public GameObject[] platformsss;

	private float distanceBetween;
	private int whichPlatform;
	private float[] platformWidths;
	public float minHeight;
	public Transform maxHeight;
	public Transform minHeightl;
	public float heightChange;
	public float maxHeightpt;
	public float minHeightpt;
	private float maxDistance;
	private coinMaker theCoinMaker;

	private iceCream theIceCreamScript;
	private hatPooler thehatpooler;



	// Use this for initialization
	void Start () {
		
		thehatpooler = FindObjectOfType<hatPooler> ();
		theCoinMaker = FindObjectOfType<coinMaker> ();
		theIceCreamScript = FindObjectOfType<iceCream> ();
		minHeightpt = minHeightl.transform.position.y;
		maxHeightpt = maxHeight.transform.position.y;
		maxDistance = (float)((maxHeightpt - minHeightpt)*0.85);

		//platformWidth = platform.GetComponent<BoxCollider2D> ().size.x;
		platformWidths= new float[objectPoolerScript.Length];
		for (int i = 0; i < objectPoolerScript.Length; i++) {
			platformWidths [i] = objectPoolerScript[i].oneground.GetComponent<BoxCollider2D> ().size.x;
		}
	}
	public Transform maxCoinHeight;
	private float randomHeight;
	private float randomX;
	private float randomX2;
	private float xofCoins;
	private float randomheightChange1;
	private float randomheightChange2;
	public float closeTogetherChance;
	private float closeTogetherRange;

	//iceCreamChance
	public float iceCreamChance;
	private float iceCreamChanceRange;
	private float iceCreamHeight;
	private float iceCreamWidth;

	private Vector3 iceCreamPosition;


	//hatChance
	public float hatChance;
	private float hatChanceRange;
	private float hatCreamHeight;
	private float hatCreamWidth;

	private Vector3 hatPosition;

	//coin appearing chance numbers
	public float chanceOfCoinsOutOfTen;
	private float coinChanceRandom;
	private float upOrDown;
	//coinxposition on platormf
	private float coinXRandom;
	private float coinX;


	//transform so no up coins on first platform
	public Transform coinsstart;




	// Update is called once per frame
	void Update () {
		upOrDown = Random.Range (maxDistance, -maxDistance);
		heightChange = transform.position.y + upOrDown;
			if (heightChange > maxHeightpt) {
				heightChange = maxHeightpt;
			} else if (heightChange < minHeightpt) {
				heightChange = minHeightpt;
			}


			distanceBetween = Random.Range (distanceBetweenMin, distanceBetweenMax);
			whichPlatform = Random.Range (0, objectPoolerScript.Length);
		if (transform.position.x < platformGenerationPoint.transform.position.x) {
			randomHeight = Random.Range (2, 7);
			randomheightChange1 = Random.RandomRange (2, 7);
			randomheightChange2 = Random.RandomRange (2, 7);
			transform.position = new Vector3 (transform.position.x + (platformWidths [whichPlatform] / 2) + distanceBetween, heightChange, transform.position.z);
			//Instantiate (objectPoolerScript[whichPlatform], transform.position, transform.rotation);
			if ((randomHeight + transform.position.y) > maxCoinHeight.transform.position.y) {
				randomHeight = maxCoinHeight.transform.position.y;
			}
			if ((randomheightChange1 + transform.position.y) > maxCoinHeight.transform.position.y) {
				randomheightChange1 = maxCoinHeight.transform.position.y;
			}
			if ((randomheightChange2 + transform.position.y) > maxCoinHeight.transform.position.y) {
				randomheightChange2 = maxCoinHeight.transform.position.y;
			}
			GameObject anotherGround = objectPoolerScript [whichPlatform].objectPooler ();
			anotherGround.transform.position = transform.position;
			anotherGround.transform.rotation = transform.rotation;
			anotherGround.SetActive (true);
			closeTogetherRange = Random.Range (0, 10);
			if (closeTogetherChance > closeTogetherRange) {
				randomX = Random.Range (0, platformWidths [whichPlatform] / 3);
			} else if (closeTogetherChance <= closeTogetherRange) {
				randomX = Random.Range (platformWidths [whichPlatform] / 3, platformWidths [whichPlatform]);
			}
			randomX2 = Random.Range (0, platformWidths [whichPlatform]);

			//thebackGroundPoolers.backPool (transform.position);
			Vector3 coin1 = new Vector3 (transform.position.x + randomX2, transform.position.y + randomHeight, transform.position.z);
			Vector3 coin2 = new Vector3 (transform.position.x + randomX + randomX2, transform.position.y + randomheightChange1, transform.position.z);
			Vector3 coin3 = new Vector3 (transform.position.x - randomX - randomX + randomX2, transform.position.y + randomheightChange2, transform.position.z);
			/*if (((transform.position.x + randomX2) < transform.position.x + platformWidths [whichPlatform] / 2) && ((transform.position.x + randomX2) > transform.position.x - platformWidths [whichPlatform] / 2)) {
				theCoinMaker.MakeCoins (coin1);
			}
			if ((coin2.x < (coin1.x - 1f)) || (coin2.x > (coin1.x + 1f))) {
				if (((transform.position.x + randomX + randomX2) < transform.position.x + platformWidths [whichPlatform] / 2) && ((transform.position.x + randomX + randomX2) > transform.position.x - platformWidths [whichPlatform] / 2)) {
					theCoinMaker.MakeCoins (coin2);
				}
			}
			if (((coin3.x < (coin1.x - 1f)) || (coin3.x > (coin1.x + 1f))) && ((coin3.x < (coin2.x - 1f)) || (coin3.x > (coin2.x + 1f)))){
				if (((transform.position.x - randomX - randomX + randomX2) < transform.position.x + platformWidths [whichPlatform]/2) && ((transform.position.x - randomX - randomX + randomX2) > transform.position.x - platformWidths [whichPlatform]/2)) {
					theCoinMaker.MakeCoins (coin3);
				}
			}*/
			coinChanceRandom = Random.Range (0, 10);

			if (chanceOfCoinsOutOfTen > coinChanceRandom) {
				if (platformWidths [whichPlatform] > 8) {
					if ((heightChange < maxHeightpt)) {
						theCoinMaker.MakeCoins8 (new Vector3 (transform.position.x, transform.position.y + 2, transform.position.z));
					} else
						theCoinMaker.MakeCoins3flat (transform.position);
				} else if (platformWidths [whichPlatform] > 5) {
					coinXRandom = Random.Range (-2,2);
					coinX = transform.position.x + coinXRandom;
					if ((heightChange < maxHeightpt)) {
						
						theCoinMaker.MakeCoins3 (new Vector3 (transform.position.x+coinXRandom/2, transform.position.y + 2, transform.position.z));
					} else if ((heightChange > maxHeightpt))
						/*coinXRandom = Random.Range (-2,2);*/
						theCoinMaker.MakeCoins3flat (new Vector3(coinX,transform.position.y, transform.position.z));
				}
			}
			coinChanceRandom = Random.Range (0, 10);
			if (chanceOfCoinsOutOfTen > coinChanceRandom) {
				if (upOrDown > 3 && heightChange < maxHeightpt && distanceBetween >= 3 && transform.position.x>coinsstart.transform.position.x) {
					theCoinMaker.MakeCoins3endflyup (new Vector3 (transform.position.x - (platformWidths [whichPlatform] / 2), transform.position.y, transform.position.z));
				}
				if (upOrDown < -3 && distanceBetween >= 3) {
					theCoinMaker.MakeCoins3endflydown (new Vector3 (transform.position.x - platformWidths [whichPlatform] / 2, transform.position.y + 2, transform.position.z));
				}
			}

		
						


			//iceCreamGenerator

			iceCreamChanceRange = Random.Range (0, 10);
			iceCreamHeight = Random.Range (2, 4);
			iceCreamWidth = Random.Range (-platformWidths [whichPlatform]/2, platformWidths [whichPlatform]/2);
			if (iceCreamChance > iceCreamChanceRange) {
				iceCreamPosition = new Vector3 (transform.position.x + iceCreamWidth, transform.position.y + iceCreamHeight, transform.position.z);
				if (theCoinMaker.coinPoolers.oneground.transform.position.x>=iceCreamPosition.x+1 || theCoinMaker.coinPoolers.oneground.transform.position.x<=iceCreamPosition.x-1) {
					theIceCreamScript.MakeIceCreams (iceCreamPosition);
				}
			}

			//hatGenerator
			hatChanceRange = Random.Range (0, 10);
			hatCreamHeight = Random.Range (2, 4);
			hatCreamWidth = Random.Range (-platformWidths [whichPlatform]/2, platformWidths [whichPlatform]/2);
			if (hatChance > hatChanceRange) {
				hatPosition=new Vector3(transform.position.x+hatCreamWidth,transform.position.y+hatCreamHeight,transform.position.z);
				if ((theIceCreamScript.coinPoolers.oneground.transform.position.x>= hatPosition.x+1 || theIceCreamScript.coinPoolers.oneground.transform.position.x<= hatPosition.x-1 )&& (theCoinMaker.coinPoolers.oneground.transform.position.x<=hatPosition.x-1 ||theCoinMaker.coinPoolers.oneground.transform.position.x>=hatPosition.x+1)) {
					thehatpooler.MakeHats (hatPosition);
				}
			}



				transform.position = new Vector3 (transform.position.x + (platformWidths [whichPlatform] / 2), transform.position.y, transform.position.z);
			}


	}
}
