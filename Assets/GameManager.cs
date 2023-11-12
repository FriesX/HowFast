using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI	;



public class GameManager : MonoBehaviour
{
	private int scoreDisplay;
	
	public Text scoreText;
	public Text scoreText2;
	public Text timeText;
	public GameObject gameUI;
	public GameObject timeOut;
	
	
	private float timer=30.0F;
    // Start is called before the first frame update
    void Start()
	{
		Time.timeScale=1;
	    scoreText.text="Score : "+ 0;

    }

    // Update is called once per frame
    void Update()
    {
	    timer-=Time.deltaTime;
	    timeText.text = "Time Left: " + Mathf.Ceil(timer) +"s";
	    
	    if(timer	<=0){

	    	Time.timeScale=0;
	    	gameUI.SetActive(false);
	    	timeOut.SetActive(true);
	    	
	    }
	    
	    
    }
    
	public void playerScore(int score){
		scoreDisplay=scoreDisplay+score;
		
		scoreText.text="Score : " + scoreDisplay.ToString();
		scoreText2.text="Score : "+ scoreDisplay.ToString();
	}
    
	public void replayGame(){

		SceneManager.LoadScene(0);
		
	}

    
}
