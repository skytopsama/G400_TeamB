using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawn : MonoBehaviour {

	public Transform[] SpawnPoints;
	public float spawnTime = 1.5f;
	public GameObject[] Powerup;

	void Start ()
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Spawn ()
	{
		int spawnIndex = Random.Range (0, SpawnPoints.Length);
		int objectIndex = Random.Range (0, Powerup.Length);
		Instantiate (Powerup[objectIndex], SpawnPoints [spawnIndex].position, SpawnPoints [spawnIndex].rotation);
	}

}
