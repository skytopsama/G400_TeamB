using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public float startingHealth = 100f;
	public float currentHealth;
	public GUIStyle myStyle;

	bool gameOver = false;

	private GameManager gameManager;

	void Awake ()
	{
		currentHealth = startingHealth;
	}

	void Start() 
	{
		gameManager = GetComponent<GameManager> ();
	}

	void OnGUI ()
	{
		GUI.Label (new Rect (90, 40, 50, 50), "" + currentHealth + "/" + startingHealth, myStyle);
	}

	void Update ()
	{
		if (currentHealth <= 0)
		{
			currentHealth = 0;
			gameOver = true;
		}
		//Shoud end the game
		//EndGame ();
	}

	void EndGame (){
		if (gameOver) 
		{
			gameManager.Quit ();
		}
			
	}
}