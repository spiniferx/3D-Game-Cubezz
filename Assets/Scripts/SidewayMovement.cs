using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidewayMovement : MonoBehaviour {

	// Use this for initialization

	public Rigidbody siderb;
	public float sidewayMoveSpeed;
	public Transform player1;
	public Vector3 sidemover;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//siderb.AddForce (0, 0,sidewayMoveSpeed * Time.deltaTime);
		sidemover.z = player1.position.z;
		transform.position = new Vector3 (transform.position.x, transform.position.y, sidemover.z);
}
}
