using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizationScript : MonoBehaviour {

	public Texture2D BodyTexture1;
	public Texture2D HeadTexture1;
	public Texture2D ThrusterTexture1;

	public Transform Head;
	public Transform Body;
	public Transform Thruster;
	//bool customON;

	void Awake ()
	{
		Time.timeScale = 0.0f;
		//customON = true;
	}
		
	void OnGUI ()
	{
		GUI.Box (new Rect (100, 100, 300, 400), "Customize Your Sub!");
		GUI.Box (new Rect (100, 200, 75, 75), HeadTexture1);
		GUI.Box (new Rect (100, 275, 75, 75), BodyTexture1);
		GUI.Box (new Rect (100, 350, 75, 75), ThrusterTexture1);
		if (GUI.Button (new Rect (100, 100, 100, 50), "Begin"))
		{
			Time.timeScale = 1.0f;
		}
	}

	/*void OnMouseDown ()
	{
		if (other.name == "HeadTexture1") {
			
			//replace sprite
		}
	}*/
}
