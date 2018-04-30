using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public Canvas gameOverMenu;
	public PlayerMovement playerMove;
	void Start()
	{
		gameOverMenu.enabled = false;
	}

	public void EndGame()
	{
		Debug.Log ("Game Over");
		//SceneManager.LoadScene ("Scene");
		//Time.timeScale = 0.0f;
		gameOverMenu.enabled = true;
		Time.timeScale = 0.0f;
	}

	public void Retry()
	{
		Time.timeScale = 1.0f;
		SceneManager.LoadScene ("Scene");
		gameOverMenu.enabled = false;
		playerMove.enabled = true;

		//SceneManager.LoadScene ("Scene");
	//	Time.timeScale = 1.0f;

	}
}
