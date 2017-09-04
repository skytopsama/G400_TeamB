using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

	public static int score;

	void Awake ()
	{
		score = 0;
	}

	void OnGUI ()
	{
		GUI.Label (new Rect (10, 30, 100, 20), "Score:" + score);
	}
}
