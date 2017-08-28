using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShots : MonoBehaviour {

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

		if (Input.GetButton ("Fire1") && Time.time > nextFire)
		{
			//GameObject clone = 
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation); //as GameObject;
			//audioSource.Play();
		}

	}
}
