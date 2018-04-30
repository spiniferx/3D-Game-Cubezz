using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization

	public Rigidbody rb;

	public float moveSpeed;
	public float sidewaySpeed;
	public float acceleration = .005f;
	public float maxSpeed = 5500f;

	void Start () {

		//rb.AddForce (0, 0, moveSpeed * Time.deltaTime);
	}
		
	// Update is called once per frame
	void FixedUpdate () {

		//rb.AddForce (0, 0, moveSpeed * Time.deltaTime);
		transform.Translate(0,0,.1f* Time.deltaTime*moveSpeed);
		//transform.Rotate((Vector3.forward * Time.deltaTime), Space.Self);
		//transform.Rotate(Vector3.right * Time.deltaTime*15f);

		moveSpeed += acceleration;

		if (moveSpeed > maxSpeed) {
		
			moveSpeed = maxSpeed;
		}


		for (int i =0; i<Input.touchCount; i++) {
			Touch touch = Input.GetTouch(i);

			if (touch.position.x < Screen.width/2)
			{
				rb.AddForce (sidewaySpeed * Time.deltaTime, 0,0,ForceMode.VelocityChange );
				//transform.Translate(Vector3.left * Time.deltaTime * PlayerMoveSpeed);
				//transform.Translate(-sidewaySpeed * Time.deltaTime, 0,0);
			}
			if (touch.position.x > Screen.width/2)
			{
				rb.AddForce (-sidewaySpeed * Time.deltaTime, 0,0,ForceMode.VelocityChange );
				//transform.Translate(Vector3.right * Time.deltaTime * PlayerMoveSpeed);
				//transform.Translate (sidewaySpeed * Time.deltaTime, 0,0);

			}
		}


		if(Input.GetKey("d") && transform.position.x < 7.5f)
		{
			rb.AddForce (sidewaySpeed * Time.deltaTime, 0,0,ForceMode.VelocityChange );
		}
		if(Input.GetKey("a") && transform.position.x > -7.5f)
		{
			rb.AddForce (-sidewaySpeed * Time.deltaTime, 0,0,ForceMode.VelocityChange );

		}


	}
}
