using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour {

	public float fireTime = 0.5f;

	void Start () 
	{
		//InvokeRepeating ("Fire", 0f, fireTime);	
	}

	void Update()
	{
		if (Input.GetButtonDown("Fire1")){
			InvokeRepeating("Fire", 0f, fireTime);
		}

		if (Input.GetButtonUp("Fire1")){
			CancelInvoke("Fire");
		}
	}
	
	// Update is called once per frame
	void Fire () 
	{
		//Debug.Log ("FIRE!");
		GameObject obj = ObjectPoolerScript.current.GetPooledObject ();

		if (obj == null) return;

		obj.transform.position = transform.position;
		obj.transform.rotation = transform.rotation;
		obj.SetActive (true);
	}
}
