using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizationScript : MonoBehaviour {

	public Texture2D HeadTexture1;
	public Texture2D BodyTexture1;
	public Texture2D ThrusterTexture1;
	public Texture2D HeadTexture2;
	public Texture2D BodyTexture2;
	public Texture2D ThrusterTexture2;

	public Transform Head;
	public Transform Body;
	public Transform Thruster;

	void Awake ()
	{
		Time.timeScale = 0.0f;
	}
		
	void OnGUI ()
	{
		GUI.Box (new Rect (100, 250, 300, 400), "");
		GUI.Label (new Rect (185, 300, 150, 50), "Customize Your Sub!");

		GUI.Box (new Rect (160, 350, 75, 75), HeadTexture1);
		GUI.Box (new Rect (160, 425, 75, 75), BodyTexture1);
		GUI.Box (new Rect (160, 500, 75, 75), ThrusterTexture1);
		GUI.Box (new Rect (260, 350, 75, 75), HeadTexture2);
		GUI.Box (new Rect (260, 425, 75, 75), BodyTexture2);
		GUI.Box (new Rect (260, 500, 75, 75), ThrusterTexture2);

		if (GUI.Button (new Rect (100, 675, 100, 50), ""))
		{
			Time.timeScale = 1.0f;
			Destroy (this);
		}
		GUI.Label (new Rect (135, 690, 100, 50), "Begin");
	}
}
