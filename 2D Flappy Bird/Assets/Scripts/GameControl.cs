﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class GameControl : MonoBehaviour {

	public static GameControl instance; 
	public GameObject gameOverText;
	public Text scoreText;
	public bool gameOver = false; 
	public float scrollSpeed = -4f;

	public static int scoreAll = 0;

	// Use this for initialization

	//Awake skjer før start
	void Awake () 
	{
		if (instance == null) {
			instance = this;
		} else if (instance != this) 
		{
			Destroy (gameObject); 
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gameOver == true && Input.GetMouseButtonDown (0)) 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}

	public void BirdScored ()
	{
		if (gameOver)
		{
			return;
		}
		scoreAll++; 
		scoreText.text = "Score " + scoreAll.ToString (); 
	}

	public void BirdDied()
	{
		gameOverText.SetActive (true); 
		gameOver = true; 
	}
}
