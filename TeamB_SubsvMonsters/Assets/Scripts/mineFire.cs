using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineFire : MonoBehaviour {

	public float fireTime = 3f;

	void Start () 
	{
		//InvokeRepeating("Fire", fireTime, fireTime);		
	}

	void Update()
	{
		if (Input.GetButtonDown("Fire2")){
			Debug.Log ("Firing mine");
			Invoke("Fire", fireTime);
		}

		if (Input.GetButtonUp("Fire2")){
			CancelInvoke("Fire");
		}
	}

	// Update is called once per frame
	void Fire () 
	{
		GameObject obj = ObjectPoolerScript.current.GetPooledObject ();

		if (obj == null) return;

		obj.transform.position = transform.position;
		obj.transform.rotation = transform.rotation;
		obj.SetActive (true);
	}
}
