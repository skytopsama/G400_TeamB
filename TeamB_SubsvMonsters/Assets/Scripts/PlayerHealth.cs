using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public float startingHealth;
	public float currentHealth;

	void Awake ()
	{
		currentHealth = startingHealth;
	}

	void OnGUI()
	{
		GUI.Label (new Rect(10, 10, 100, 20), "Hello World!");
	}

	/*void Damage ()
	{
		if (currentHealth <= 0)
		{
			//player gameover screen
		}
	}*/
}