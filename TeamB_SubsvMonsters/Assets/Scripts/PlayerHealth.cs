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

	/*void Update ()
	{
		GUIText (currentHealth + "/" + startingHealth);
	}*/

	public void TakeDamage (float amount)
	{
		currentHealth -= amount;
		//hungerSlider.value = currentHunger;
	}
}