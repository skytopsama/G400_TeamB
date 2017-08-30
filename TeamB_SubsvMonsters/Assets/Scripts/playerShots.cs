using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShots : MonoBehaviour {

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;

	//private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		float nextFire = Time.time + fireRate;

		if (Input.GetMouseButtonDown (0)) //&& Time.time > nextFire)
		{
			//GameObject clone = 
			Debug.Log("Left Click");
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation); //as GameObject;
			//audioSource.Play();
		}

	}
}
