using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour {

	public static int currentScore;

	void Awake ()
	{
		currentScore = 0;
	}

	void OnGUI()
	{
		GUI.Label (new Rect(10, 30, 100, 20), "Score:" + currentScore);
	}
}