using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour {
	public int speed;
	public float lifeTime;
	//public int power;


	// Use this for initialization
	void OnEnable () {
		GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
		Invoke ("Repool", lifeTime);
	}

	void Repool(){
		Debug.Log ("bullet destroyed");
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void OnDisable () {
		CancelInvoke ();
	}

	//destorys enemy if it collides with bullet
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Enemy" )
		{
			Destroy(other.gameObject);
			Repool ();
		}

	}
}
