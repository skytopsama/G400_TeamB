using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour {
	public float speed;
	public float lifeTime;
	//prefab for explosion
	public GameObject explosion;
	//public int power;

	void Awake()
	{
		speed = 10.0f;
	}


	void OnEnable () {
		GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
		Invoke ("Repool", lifeTime);
	}

	void Repool(){
		Debug.Log ("bullet destroyed");
		Instantiate (explosion, transform.position, Quaternion.identity);
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void OnDisable () {
		CancelInvoke ();
	}

	//destorys enemy if it collides with bullet
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Enemy" )
		{
			Destroy(other.gameObject);
			Repool ();
		}
	}
}
