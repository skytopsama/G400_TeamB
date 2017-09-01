using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyByContact : MonoBehaviour {

	public float startingHealth;
	public float currentHealth;
	//public Slider healthSlider;
	PlayerHealth playerHealth;

	void Awake ()
	{
		playerHealth = GetComponent <PlayerHealth> ();
		currentHealth = startingHealth;
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "Enemy" )
		{
			Destroy(other.gameObject);
			playerHealth.currentHealth -= 30;
		}
	}
}
