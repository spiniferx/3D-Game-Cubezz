using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour {

	public Transform player;
	public Text scoreText;
	int score;

	void Start()
	{
		score = 0; 
		InvokeRepeating ("ScoreUpdate", 1f, 0.5f);
	}

	void Update()
	{
		scoreText.text = score.ToString();
	}
	// Update is called once per frame
	void ScoreUpdate ()
	{
		//scoreText.text = player.position.z.ToString ("0");
		score = score+1;
	}
}
