using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public int startingHealth;
	public int currentHealth;
	PlayerHealth playerHealth;

	void Awake ()
	{
		currentHealth = startingHealth;
	}

	void OnGUI()
	{
		GUI.Label (new Rect(10, 10, 100, 20), "Health:" + currentHealth);
	}

	/*void Damage ()
	{
		if (currentHealth <= 0)
		{
			//player gameover screen
		}
	}*/
}