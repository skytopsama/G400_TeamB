using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public float startingHealth = 100f;
	public float currentHealth;

	void Awake ()
	{
		currentHealth = startingHealth;
	}

	void OnGUI ()
	{
		GUI.Label (new Rect (20, 20, 100, 50), "" + currentHealth);
	}
}