using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineFire : MonoBehaviour {

	public GameObject mine;

	public float dropRate;
	float nextDrop;

	Transform mineSpawn;

	void Start () 
	{
		mineSpawn = this.transform;		
	}

	void Update()
	{
		if (Input.GetButtonDown("Fire2") && Time.time > nextDrop){
			Debug.Log ("Dropping mine");

			nextDrop = Time.time + dropRate;
			Instantiate(mine, mineSpawn.position, mineSpawn.rotation);
		}
	}

	// Update is called once per frame
	void Deploy () 
	{
		GameObject obj = ObjectPoolerScript.current.GetPooledObject ();

		if (obj == null) return;

		obj.transform.position = transform.position;
		obj.transform.rotation = transform.rotation;
		obj.SetActive (true);
	}
}
