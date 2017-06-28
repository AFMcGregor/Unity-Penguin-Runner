using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {

	private float highScore;
	public float secondhighscore;
	public float thirdhighscore;
	public float potentialhighscore;
	public float tsecondhighscore;
	public float tthirdhighscore;
	public float thighScore;
	public GameObject peng;

	public GameObject[] panell;
	public GameObject[] buton;
	public Text[] yourScore;
	public Text[] text;
	//AudioSource audio;

	void Start(){
		//audio = GetComponent<AudioSource> ();
		for (int i=0; i<=panell.Length;i++){
		panell[i].SetActive(false);
		buton[i].SetActive(false);
		text[i].enabled = false;
		yourScore[i].enabled = false;
		}
		highScore = PlayerPrefs.GetFloat ("highScore");
		secondhighscore = PlayerPrefs.GetFloat ("secondhighscore");
		thirdhighscore = PlayerPrefs.GetFloat ("thirdhighscore");
		highScore = PlayerPrefs.GetFloat ("thighScore");
		secondhighscore = PlayerPrefs.GetFloat ("tsecondhighscore");
		thirdhighscore = PlayerPrefs.GetFloat ("tthirdhighscore");
		potentialhighscore = PlayerPrefs.GetFloat ("potentialhighscore");
	}

	public bool yesgui=false;
	void OnGUI(){
		if (yesgui) {
			//audio.Play ();
		
			yourScore[0].text= "Your score: " + Mathf.Round(PlayerPrefs.GetFloat("potentialhighscore"));
			panell[0].SetActive(true);
			buton[0].SetActive(true);
			text[0].enabled = true;
			yourScore[0].enabled = true;
		}
	}

	public void died(){
		
		//audio.Play ();
		yesgui = true;
		//SceneManager.LoadScene (0);

	

	}

	public void scene1(){
		
		SceneManager.LoadScene (1);
		Time.timeScale = 1;
	}

	public void resetHighScore(){
		PlayerPrefs.SetFloat ("highScore", 0);
		PlayerPrefs.SetFloat ("secondhighscore", 0);
		PlayerPrefs.SetFloat ("thirdhighscore", 0);
		PlayerPrefs.SetFloat ("potentialhighscore", 0);
		SceneManager.LoadScene (0);
	}

	public void quit(){
		
		Application.Quit();
	}

	public void pause(){

			Time.timeScale = 0;

	}

	public void play(){
		
		Time.timeScale = 1;
	}

	public void Tutorial(){
		Time.timeScale = 1;
		SceneManager.LoadScene (2);

	}

	public void mainMenu(){
		
		//PlayerPrefs.SetFloat ("potentialhighscore", 0);
		PlayerPrefs.SetFloat("potentialhighscore",0);

		SceneManager.LoadScene (0);
		Time.timeScale = 1;
	}


}
