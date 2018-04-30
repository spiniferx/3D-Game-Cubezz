using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour {

	// Use this for initialization

	public GameObject platformDestructionPoint; 

	void Start () {

		platformDestructionPoint = GameObject.Find ("PlatformDestructionPoint");
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.z < platformDestructionPoint.transform.position.z) {
		
			//Destroy (gameObject);
			gameObject.SetActive(false);
			Debug.Log ("Its not deactivating");
		}
	}
}
