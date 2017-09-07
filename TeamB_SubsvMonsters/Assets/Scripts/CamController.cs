using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	//used for following player
	public bool IsFollowing { get; set; }

	//bounds of the level
	//public BoxCollider2D LevelBounds;
	/*private Vector3
		_min,
		_max;*/

	// Use this for initialization
	void Start () 
	{
		offset = transform.position - player.transform.position;
		//_min = LevelBounds.bounds.min;
		//_max = LevelBounds.bounds.max;
		IsFollowing = true;
	}
		
	
	// Update is called once per frame
	/*void Update () 
	{
		var x = transform.position.x;
		var y = transform.position.y;



		var camHalfWidth = Camera.main.orthographicSize * ((float)Screen.width / Screen.height);

		//Lock camera to right or left bound if touching it
		x = Mathf.Clamp(x, _min.x, _max.x - camHalfWidth);

		//Lock camera to top or bottom bound of touching it
		y = Mathf.Clamp(y, _min.y, _max.y - Camera.main.orthographicSize);

		transform.position = new Vector3 (x, y, transform.position.z);

	}*/

	void LateUpdate ()
	{
		if (IsFollowing) 
		{
			transform.position = player.transform.position + offset;
		}
	}
}