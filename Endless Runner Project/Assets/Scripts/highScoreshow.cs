using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScoreshow : MonoBehaviour {
	public Text highScoreShow;
	public Text secondhighscoreshow;
	public Text thirdhighscoreshow;
	private float highScore;
	private float thesecondhighscore;
	private float thirdhighscore;
	private float potentialhighscore;
	// Use this for initialization
	void Start () {
		highScore = PlayerPrefs.GetFloat ("highScore");
		thesecondhighscore = PlayerPrefs.GetFloat ("secondhighscore");
		thirdhighscore = PlayerPrefs.GetFloat ("thirdhighscore");
		potentialhighscore = PlayerPrefs.GetFloat ("potentialhighScore");
	}
	
	// Update is called once per frame
	void Update () {
		/*if (potentialhighscore > highScore) {
			PlayerPrefs.SetFloat ("highScore", potentialhighscore);
			PlayerPrefs.SetFloat ("secondhighscore", highScore);
			PlayerPrefs.SetFloat ("thirdhighscore", thesecondhighscore);

		} else if (potentialhighscore > thesecondhighscore) {
			PlayerPrefs.SetFloat ("secondhighscore", potentialhighscore);
			PlayerPrefs.SetFloat ("thirdhighscore", thesecondhighscore);
		} else if (potentialhighscore > thirdhighscore) {
			PlayerPrefs.SetFloat ("thirdhighscore", potentialhighscore);
		}

		Debug.Log(PlayerPrefs.GetFloat("potentialhighscore"));
		Debug.Log(PlayerPrefs.GetFloat("highScore"));*/
		highScoreShow.text = "Highscore " + Mathf.Round(highScore);
		secondhighscoreshow.text = "Second high score: " + Mathf.Round(thesecondhighscore);
		thirdhighscoreshow.text = "Third high score: " + Mathf.Round (thirdhighscore);
	}
}
