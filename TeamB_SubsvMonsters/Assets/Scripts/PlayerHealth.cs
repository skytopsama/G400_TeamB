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
		GUI.Label (new Rect(10, 10, 100, 20), "Health:" + currentHealth);
	}

	void Update ()
	{
		if (currentHealth < 0)
		{
			currentHealth = 0;
		}
	}

	/*void Damage ()
	{
		if (currentHealth <= 0)
		{
			//player gameover screen
		}
	}*/
}