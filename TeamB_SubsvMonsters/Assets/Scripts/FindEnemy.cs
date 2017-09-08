using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : MonoBehaviour {

	Transform target;
	List<Transform> enemies;
	float speed;
	float autoDestroyAfter;
	//prefab for explosion
	GameObject explosion;
	/*homing sensitivity of the missle
	 * Range[0.0, 1.0] where 0 will disable homing and 1 will follow target "like crazy"
	 * Param is fed into Slerp*/
	float homingSensitivty = 0.1f;

	//float minDistance = 0.1f;
	//float range;

	private BulletDestroy bulletDestroy;

	void Start()
	{
		target = null;
		enemies = new List<Transform> ();
		AddEnemiesToList ();

		bulletDestroy = GetComponent<BulletDestroy>();

		speed = bulletDestroy.speed;

		//StartCoroutine (AutoExplode ());
	}

	public void AddEnemiesToList()
	{
		GameObject[] ItemsInList = GameObject.FindGameObjectsWithTag("Enemy");
		Debug.Log (ItemsInList);
		foreach (GameObject _Enemy in ItemsInList)
		{
			AddTarget(_Enemy.transform);
		}
		Debug.Log (enemies);
	}

	public void AddTarget (Transform enemy)
	{
		enemies.Add (enemy);
		Debug.Log (enemy + "added");
	}

	public void RemoveTarget (Transform enemy)
	{
		enemies.Remove (enemy);
		Debug.Log (enemy + "removed");
	}

	public void DistanceToTarget()
	{	if (enemies != null) 
		{
			enemies.Sort (delegate (Transform t1, Transform t2) {
				return 
					Vector3.Distance (t1.transform.position, transform.position)
					.CompareTo (
					Vector3.Distance (t2.transform.position, transform.position)
				);
			});
		}
	}

	public void TargetedEnemy()
	{
		if (target == null)
		{
			DistanceToTarget ();
			target = enemies [0];
			Debug.Log(enemies[0].transform);
		}
	}



	void FixedUpdate ()
	{
		
	}

	void Update ()
	{
		AddEnemiesToList ();
		if (enemies != null)
		{
			TargetedEnemy();
			float dist = Vector3.Distance(target.transform.position,transform.position);
			//if(dist <150)
			//{
			transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
			//}
		}

//		if (target != null) {
//			Vector3 relativePos = target.position - transform.position;
//			Quaternion rotation = Quaternion.LookRotation (relativePos);
//			transform.rotation = Quaternion.Slerp (transform.rotation, rotation, homingSensitivty);
//		}
//		transform.Translate (0, 0, speed * Time.deltaTime, Space.Self);

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Enemy") 
		{
			RemoveTarget (other.transform);
			TargetedEnemy ();
		}
	}

//	private void ExplodeSelf()
//	{
//		Instantiate (explosion, transform.position, Quaternion.identity);
//		Destroy (gameObject);
//	}

//	IEnumerator AutoExplode()
//	{
//		yield return new WaitForSeconds(autoDestroyAfter);
//
//		ExplodeSelf();
//	}
}
