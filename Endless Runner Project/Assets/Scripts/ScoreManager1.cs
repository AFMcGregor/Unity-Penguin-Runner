using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager1 : MonoBehaviour {


	public Text scoreText;
	public Text highScoreText;

	public Image frozenScore;

	public float scoree;
	private float highScore;
	public float secondhighscore;
	public float tthirdhighscore;
	private float thighScore;
	public float tsecondhighscore;
	public float thirdhighscore;
	public float potentialhighscore;
	public float pointsPerTime;
	public GameObject peng;
	public gameManager gameManager;

	private bool iceCreamTouch=false;

	//Use this for initialization
	void Start () {
		frozenScore.enabled = false;
		highScore = PlayerPrefs.GetFloat ("highScore");
		secondhighscore = PlayerPrefs.GetFloat ("secondhighscore");
		if (thirdhighscore != null) {
			thirdhighscore = PlayerPrefs.GetFloat ("thirdhighscore");
		} else {
			thirdhighscore = 0;
		}


	}

	IEnumerator MyCoroutine(){
		iceCreamTouch = true;
		frozenScore.enabled = true;
		yield return new WaitForSeconds (8);
		iceCreamTouch = false;
		frozenScore.enabled = false;
	}









	/*void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag=="coin"){
			
			Debug.Log ("lllll");
		}
	}*/


	// Update is called once per frame
	public void Update () {

		//Debug.Log (thirdhighscore);
		//Debug.Log (secondhighscore);
		//Debug.Log (highScore);

		/*if (scoree > highScore) {
			highScore = scoree;
			PlayerPrefs.SetFloat("potentialhighscore",scoree)
		}
		else if (scoree
		if (scoree > thirdhighscore) {
			thirdhighscore = scoree;
		}
*/
		PlayerPrefs.SetFloat ("potentialhighscore", scoree);
		if (thirdhighscore < scoree) {
			potentialhighscore = scoree;

		}

		if (potentialhighscore > highScore) {
			if (peng.transform.position.y < -5 && SceneManager.GetActiveScene ().buildIndex == 1) {
				PlayerPrefs.SetFloat ("highScore", potentialhighscore);
				PlayerPrefs.SetFloat ("secondhighscore", highScore);
				PlayerPrefs.SetFloat ("thirdhighscore", secondhighscore);
			}
			highScoreText.text = "Personal best!";

		} else if (potentialhighscore > secondhighscore) {
			if (peng.transform.position.y < -5 && SceneManager.GetActiveScene ().buildIndex == 1) {
				PlayerPrefs.SetFloat ("secondhighscore", potentialhighscore);
				PlayerPrefs.SetFloat ("thirdhighscore", secondhighscore);
			}
			highScoreText.text = "1st: " + Mathf.Round (highScore);
		} else if (potentialhighscore > thirdhighscore) {
			if (peng.transform.position.y < -5 && SceneManager.GetActiveScene ().buildIndex == 1) {
				PlayerPrefs.SetFloat ("thirdhighscore", potentialhighscore);
			}
			highScoreText.text = " 2nd : " + Mathf.Round (secondhighscore);
		} else {
			highScoreText.text = "3rd : " + Mathf.Round (thirdhighscore);
		}


	
		if (SceneManager.GetActiveScene ().buildIndex == 1 && peng.transform.position.y > -4) {
			if (iceCreamTouch == false) {
				scoree += pointsPerTime * Time.deltaTime;
			}
		}

		scoreText.text = "Score: "+ Mathf.Round(scoree);
 		
	}

	public void ScoreAdd(int scoreAddPoints){
		if (iceCreamTouch == false) {
			scoree += scoreAddPoints;
		}
	}

	public void ScoreFreeze(){
		StartCoroutine (MyCoroutine());
	}




}
