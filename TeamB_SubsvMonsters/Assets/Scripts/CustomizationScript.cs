using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizationScript : MonoBehaviour {

	public Texture2D BodyTexture1;
	public Texture2D HeadTexture1;
	public Texture2D ThrusterTexture1;
	public Texture2D BodyTexture2;
	public Texture2D HeadTexture2;
	public Texture2D ThrusterTexture2;

	public Transform Head;
	public Transform Body;
	public Transform Thruster;

	private SpriteRenderer spriteRenderer;
	//bool customON;

	void Awake ()
	{
		spriteRenderer = GetComponent <SpriteRenderer> ();
		Time.timeScale = 0.0f;
		//customON = true;
	}
		
	void OnGUI ()
	{
		GUI.Box (new Rect (100, 100, 300, 400), "Customize Your Sub!");
		GUI.Box (new Rect (100, 200, 75, 75), HeadTexture1);
		GUI.Box (new Rect (100, 275, 75, 75), BodyTexture1);
		GUI.Box (new Rect (100, 350, 75, 75), ThrusterTexture1);
		GUI.Box (new Rect (200, 200, 75, 75), HeadTexture2);
		GUI.Box (new Rect (200, 275, 75, 75), BodyTexture2);
		GUI.Box (new Rect (200, 350, 75, 75), ThrusterTexture2);
		if (GUI.Button (new Rect (100, 100, 100, 50), "Begin"))
		{
			Time.timeScale = 1.0f;
		}
	}

	void OnMouseDown ()
	{
		if (HeadTexture2)
		{
			
			//replace head transform
		}
	}
}
