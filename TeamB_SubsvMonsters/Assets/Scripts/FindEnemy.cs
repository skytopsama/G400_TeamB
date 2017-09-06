using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : MonoBehaviour {

	Transform target;
	float speed;
	private float minDistance = 0.1f;
	private float range;

	BulletDestroy bulletDestroy;

	void Start()
	{
		bulletDestroy = GetComponent<BulletDestroy>();
		speed = bulletDestroy.speed;
	}

	void FixedUpdate ()
	{
		if (target == null) 
		{
			GameObject enemy = GameObject.Find ("Enemy");
			target = enemy.transform;
			Debug.Log (enemy.transform);
		}
	}

	void Update ()
	{
		if (target != null) {
			range = Vector2.Distance (transform.position, target.position);

			if (range > minDistance) {
				//Debug.Log (range);

				transform.position = Vector2.MoveTowards (transform.position, target.position, speed * Time.deltaTime);
			}
		}
	}
}
