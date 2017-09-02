using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizationScreen : MonoBehaviour {

	public Texture2D BodyTexture;
	public Texture2D HeadTexture;
	public Texture2D ThrusterTexture;
	bool customON;

	void Start ()
	{
		customON = true;
	}

	void OnGUI ()
	{
		print ("Customize");
		GUI.Box(new Rect(100, 100, 300, 400), "Customize Your Sub!");
		GUI.Box (new Rect (100, 200, 75, 75), HeadTexture);
		GUI.Box (new Rect (100, 275, 75, 75), BodyTexture);
		GUI.Box (new Rect (100, 350, 75, 75), ThrusterTexture);
		/*if (Input.GetButtonDown ("Fire1"))
		{
			if (BodyTexture)
			{
				
			}
		}*/
	}
}