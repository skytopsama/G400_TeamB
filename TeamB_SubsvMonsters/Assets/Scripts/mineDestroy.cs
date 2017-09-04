using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineDestroy : MonoBehaviour {
	public GameObject explosion;
	public float lifeTime;

	Transform explosionSpawn;


	void Awake()
	{
		explosionSpawn = this.transform;
	}

	// Use this for initialization
	void OnEnable () {
		Invoke("Die", lifeTime);
	}

	void Update() 
	{
		Debug.Log (lifeTime);
	}

	void Die(){
		Debug.Log ("mine destroyed");
		//Instantiate (explosion, explosionSpawn.position, explosionSpawn.rotation);
		Destroy(this.gameObject);
	}

	// Update is called once per frame
	void OnDisable () {
		CancelInvoke ();
	}

	//destroys enemy if it collides with mine
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Enemy" )
		{
			
			Destroy(other.gameObject);
			Destroy (gameObject);
			Instantiate (explosion, explosionSpawn.position, explosionSpawn.rotation);
		}

	}
}
