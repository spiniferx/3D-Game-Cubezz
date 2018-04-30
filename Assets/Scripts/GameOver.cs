using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {


	public PlayerMovement playerMove;

	public GameManager gameManager;

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Obstacle")
		{
			gameManager.EndGame ();
			playerMove.enabled = false;
		}

	}


}
