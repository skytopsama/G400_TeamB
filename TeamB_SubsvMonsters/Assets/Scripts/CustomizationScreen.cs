using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizationScreen : MonoBehaviour {

	//PlayerMovement playerMovement;
	//EnemySpawning enemySpawning;

	void OnGUI ()
	{
		print ("Customize");
		GUI.Box(new Rect(100, 100, 300, 400), "Customize Your Sub!");
	}
}