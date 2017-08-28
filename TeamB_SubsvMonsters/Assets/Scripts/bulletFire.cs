using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletFire : MonoBehaviour {

	public float fireTime = 0.5f;
	public GameObject bullet;

	public int pooledAmount = 20;
	List<GameObject> bullets;


	void Start () {

		bullets = new List<GameObject> ();
		//Places finite bullets in pool ready to be shot
		for (int i = 0; i < pooledAmount; i++)
		{
			GameObject obj = (GameObject)Instantiate(bullet);
			obj.SetActive(false);
			bullets.Add(obj);

		}
		//InvokeRepeating("Fire", fireTime, fireTime);
		
	}

	void Update(){
		if (Input.GetButtonDown("Fire1")){
			InvokeRepeating("Fire", fireTime, fireTime);
		}
		if (Input.GetButtonUp("Fire1")){
			CancelInvoke("Fire");
		}
	}
	
	// Update is called once per frame
	void Fire () {
		for (int i = 0; i < bullets.Count; i++) 
		{
			if (!bullets [i].activeInHierarchy) 
			{
				bullets [i].transform.position = transform.position;
				bullets [i].transform.rotation = transform.rotation;
				bullets [i].SetActive (true);
				break;
			}
		}

	}
}
