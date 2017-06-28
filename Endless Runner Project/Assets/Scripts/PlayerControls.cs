using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour {

	public float moveSpeed;
	public float jumpForce;
	public bool grounded;
	public LayerMask whatIsGround;
	private float mileStoneDistance;
	public float mileStoneDistanceAdd;

	public float Multiplier;
	public Transform pengSpot;
	public float pengSpotRadius;
	//public usei usei;


	private float timeHeld;
	public float maxHeld;
	private float maxHeldinside;
	private Rigidbody2D rb;
	private Collider2D thisCollider;
	private Animator myAnimator;
	private bool canDoubleJump;
	public int jumpCount;
	private bool jumped;
	private bool alreadyJumped=false;
	private bool jump1=false;
	private bool jump2=false;
	AudioSource audios;
	public AudioClip shimmer;
	public AudioClip runintoice;
	public AudioClip freeeofice;
	//public AudioClip death;
	public AudioClip gothatclip;



	public float jumpTime;
	private float jumpTimeCounter;

	// Use this for initialization
	void Start () {
		audios = GetComponent<AudioSource> ();
		//audio2.GetComponent<AudioSource> ();
		rb = GetComponent<Rigidbody2D> ();
		thisCollider = GetComponent<Collider2D> ();
		myAnimator = GetComponent<Animator> ();
		timeHeld = 0;
		maxHeldinside = maxHeld;
		mileStoneDistance = mileStoneDistanceAdd;
		jumpCount = 0;
		jumpTimeCounter = jumpTime;
		canDoubleJump = true;

//	
	}
	private bool onGround;
	public float doublejumpJumpForce;
	private bool jumpedd;
	private bool yesJumped=false;
	private bool stoppedJumping;
	private bool jumpedOnce = false;
	public float dbljump;
	public Transform overlap1;
	public Transform overlap2;
	public gameManager gameManager;
	public Transform wallSlide1;
	public Transform wallslide2;
	private bool hitWall;
	//public CameraFollow cam;
	//private float camvel;
	//private float rbvelocity;
	// Update is called once per frame

	private ScoreManager1 thescoreManager;


	public Transform[] jumpPointutorial;
	public Transform[] dbJump;
	public float doubleJumpForce;

	private bool gotHat=false;
	private bool gotIce=false;
	private int waitHat;
	IEnumerator Hatness(){
		gotHat=true;
		audios.PlayOneShot (gothatclip,0.4f);
		if (SceneManager.GetActiveScene ().buildIndex == 1) {
			waitHat = 10;
		} else {
			waitHat = 3;
		}
		yield return new WaitForSeconds(waitHat);
		gotHat=false;
		audios.PlayOneShot (freeeofice, 1);
	}
	private int wait;
	IEnumerator IceCreamNess(){
		gotIce=true;
		audios.PlayOneShot (runintoice, 1);
		if (SceneManager.GetActiveScene ().buildIndex == 1) {
			wait = 8;
			//yield return new WaitForSeconds (wait - 1);
		
			//yield return new WaitForSeconds(1);

			//audios.Stop ();
		} else {
			wait = 3;


		}
		yield return new WaitForSeconds (wait);
		gotIce = false;
		audios.PlayOneShot (freeeofice,1);
		
	}



	public int ScoreIncreaseAmount;

	void OnTriggerEnter2D(Collider2D other){
		/*if (other.gameObject.tag == "coin") {
			audio.Play();
		}*/
		if (other.gameObject.tag == "hat"&&gotIce==false) {
			StopCoroutine ("Hatness");
			StartCoroutine ("Hatness");
			other.gameObject.SetActive (false);
		}

		if (other.gameObject.tag == "ice cream"&& gotHat==false&&gotIce==false) {
			StartCoroutine("IceCreamNess");
			if (SceneManager.GetActiveScene ().buildIndex == 1) {
				thescoreManager.ScoreFreeze ();
				other.gameObject.SetActive (false);
			}

		}

		if (other.gameObject.tag == "coin"&&gotIce==false) {

			if (SceneManager.GetActiveScene().buildIndex==1) {
				audios.PlayOneShot(shimmer, 0.3f);
				thescoreManager.ScoreAdd (ScoreIncreaseAmount);
				other.gameObject.SetActive (false);
			}



		}



	}

	void Update () {
		if (SceneManager.GetActiveScene ().buildIndex == 1 && transform.position.y <-5) {
			//audios.PlayOneShot (death);
			//rb.velocity=new Vector2(0,0);
			gameObject.SetActive(false);
		}
			else{
		rb.velocity = new Vector2 (moveSpeed, rb.velocity.y);
			}
		for (int i = 0; i < jumpPointutorial.Length; i++) {
			if ((transform.position.x > jumpPointutorial [i].transform.position.x - 0.2) && (transform.position.x < jumpPointutorial [i].transform.position.x + 0.2)) {
				if (SceneManager.GetActiveScene ().buildIndex == 0) {
					rb.velocity = new Vector2 (7 * moveSpeed, jumpForce);
				} else {

					rb.velocity = new Vector2 (moveSpeed, jumpForce);
				}
			}
		}
		for (int i = 0; i < dbJump.Length; i++) {
			if ((transform.position.x > dbJump[i].transform.position.x - 0.2) &&(transform.position.x < dbJump[i].transform.position.x + 0.2)) {
				rb.velocity = new Vector2 (moveSpeed, doubleJumpForce);
			}
		}

			thescoreManager = FindObjectOfType<ScoreManager1> ();
		//grounded = Physics2D.IsTouchingLayers (thisCollider, whatIsGround);
		//grounded = Physics2D.OverlapCircle(pengSpot.position, pengSpotRadius, whatIsGround);
		grounded = Physics2D.OverlapArea (overlap1.position, overlap2.position, whatIsGround);
		hitWall = Physics2D.OverlapArea (wallSlide1.position, wallslide2.position, whatIsGround);
		if (SceneManager.GetActiveScene ().buildIndex == 1) {


			if (!grounded && hitWall) {
				moveSpeed = 0;
			}



			

			if (transform.position.x > mileStoneDistance) {
				mileStoneDistance = mileStoneDistance + mileStoneDistanceAdd;
				mileStoneDistanceAdd = mileStoneDistance * Multiplier;
				moveSpeed = moveSpeed * Multiplier;
			}


			//rbvelocity = rb.velocity.x;
			/*if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began && grounded) {
			jumped=true;

		}
		if (jumped && Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) {
			jumped = false;
		}
*/
			if (Input.GetMouseButtonDown (0)) {
			
				/*if (maxHeldinside > 0) {*/
				if (grounded) {
				
					rb.velocity = new Vector2 (rb.velocity.x, jumpForce);
					stoppedJumping = false;
					jumpedOnce = true;
				}
				if (!grounded && canDoubleJump && jumpedOnce == true && rb.velocity.y >= 0) {

					canDoubleJump = false;


					rb.velocity = new Vector2 (rb.velocity.x, dbljump);
					stoppedJumping = false;


				}

			}
			/*if (Input.GetMouseButton (0) && !stoppedJumping) {
			
			if (jumpTimeCounter > 0) {
				rb.velocity = new Vector2 (rb.velocity.x, jumpForce);
				jumpTimeCounter -= Time.deltaTime;
			}

		}
*/

			/*

		
		if (!jumped && Input.GetMouseButtonDown (0)) {
			
			timeHeld += Time.deltaTime;
			if (timeHeld <= maxHeldinside) {

				rb.velocity = new Vector2 (rb.velocity.x, jumpForce);
			}
}

			*/

				
			if (Input.GetMouseButtonUp (0)) {
				stoppedJumping = true;
				//canDoubleJump = false;
				jumpTimeCounter = 0;


			}




			if (grounded && yesJumped) {
			
				jumpTimeCounter = 0;
			}








			if (grounded == true && stoppedJumping) {
				canDoubleJump = true;
				jumped = false;
				jumpTimeCounter = jumpTime;
				timeHeld = 0;
				jumpedOnce = false;
		



			}
		}
		myAnimator.SetBool ("grounded", grounded);
		myAnimator.SetFloat ("speed", moveSpeed);
		myAnimator.SetBool ("gothat", gotHat);
		myAnimator.SetBool ("iceGot", gotIce);


		if (transform.position.y < -5 && SceneManager.GetActiveScene().buildIndex==1) {
			
			gameManager.died();

		}
}
	/*void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag=="coin"){
			usei.scoreText.text = "uytre";
		}
	}*/





}
