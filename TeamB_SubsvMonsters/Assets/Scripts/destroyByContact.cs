﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyByContact : MonoBehaviour {


	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "Enemy" )
		{
			Destroy(other.gameObject);
		}
	}
}
