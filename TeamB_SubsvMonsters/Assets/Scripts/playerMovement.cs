using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed;

	float startingHealth;
	float currentHealth;
	PlayerHealth playerHealth;

	void Awake ()
	{
		playerHealth = GetComponent <PlayerHealth> ();
		currentHealth = startingHealth;
	}

	void FixedUpdate () {

		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition, Vector3.forward);

		transform.rotation = rot;

		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
		GetComponent<Rigidbody2D>().angularVelocity = 0;

		float input = Input.GetAxis ("Vertical");
		GetComponent<Rigidbody2D>().AddForce (gameObject.transform.up * speed * input);
	}
		
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Enemy" )
		{
			Destroy(other.gameObject);
			playerHealth.currentHealth -= 30;
		}
	}
}
