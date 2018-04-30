using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

	// Use this for initialization

	public Transform player;
	public Vector3 offset;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = player.position + offset;
	}
}
