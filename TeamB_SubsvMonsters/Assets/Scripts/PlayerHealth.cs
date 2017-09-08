using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

	public float startingHealth = 100f;
	public float currentHealth;
	public GUIStyle myStyle;
	public Texture2D HealthIcon;

	void Awake ()
	{
		currentHealth = startingHealth;
	}

	void OnGUI ()
	{
		GUI.Label (new Rect (90, 40, 50, 50), "" + currentHealth + "/" + startingHealth, myStyle);
		GUI.Box (new Rect (30, 30, 50, 50), HealthIcon);
	}

	void Update ()
	{
		if (currentHealth <= 0)
		{
			currentHealth = 0;
		}
		if (currentHealth == 0)
		{
			SceneManager.LoadScene ("Main");
		}
	}
}