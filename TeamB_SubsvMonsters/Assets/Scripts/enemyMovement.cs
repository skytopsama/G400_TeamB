using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public Transform target;
	public float speed;
	private float minDistance = 0.1f;
	private float range;

	int currentScore;
	PlayerScore playerScore;

	void Awake ()
	{
		playerScore = GetComponent <PlayerScore> ();
	}

	void Start()
	{
		GameObject player = GameObject.Find ("Player");
		target = player.transform;
	}

	void Update ()
	{
		range = Vector2.Distance (transform.position, target.position);

		if (range > minDistance) {
			Debug.Log (range);

			transform.position = Vector2.MoveTowards (transform.position, target.position, speed * Time.deltaTime);
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Bullet1" )
		{
			Destroy(other.gameObject);
			//playerScore.currentScore += 10;
		}
	}
}
