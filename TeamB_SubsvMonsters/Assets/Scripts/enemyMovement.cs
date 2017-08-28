﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour {

	public Transform target;
	public float speed;
	private float minDistance = 0.1f;
	private float range;

	void Update ()
	{
		range = Vector2.Distance (transform.position, target.position);

		if (range > minDistance) {
			Debug.Log (range);

			transform.position = Vector2.MoveTowards (transform.position, target.position, speed * Time.deltaTime);
		}
	}
}