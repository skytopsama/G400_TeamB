using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour {

	public List<GameObject> spawnBoxes;
	public GameObject enemy;
	public float spawnTime;

	void Start(){
		InvokeRepeating ("SpawnEnemies", 0.5f, spawnTime);
	}

	void SpawnEnemies()
	{
		//choose a spawn box
		GameObject spawnBox = spawnBoxes[Random.Range(0, spawnBoxes.Count)];
		//get a point inside selected spawn box
		BoxCollider2D box = spawnBox.GetComponent<BoxCollider2D> ();
		float x = box.size.x;
		float y = box.size.y;

		Vector3 spawnPosition = 
			new Vector3 (Random.Range (-x, x), Random.Range(-y, y), 0);
		Quaternion spawnRotation = Quaternion.identity;

		Instantiate (enemy, spawnPosition, spawnRotation);
		//Debug.Log (spawnPosition);
	}
}
