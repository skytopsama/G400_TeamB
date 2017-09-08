using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public float startingHealth = 100f;
	public float currentHealth;
	//public Font myFont;

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
		GUI.contentColor = Color.white;
		//GUIStyle myStyle = new GUIStyle ();
		//myStyle.font = myFont;
		GUI.Label (new Rect (20, 20, 100, 50), "" + currentHealth);
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