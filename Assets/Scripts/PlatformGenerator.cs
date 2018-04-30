using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

	// Use this for initialization

	public GameObject thePlatform;
	public Transform generationPoint;
	public float distanceBetween;

	public  float platformWidth;

	//public ObjectPoolerEnemyBlocks objectpoolerr;

	//public GameObject[] thePlatforms;
	private int platformSelector;

	public ObjectPoolerEnemyBlocks[] objectpoolerEnemyArray;

	void Start () {

		//platformWidth = GetComponent<Collider> ().bounds.size.z;

	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.z < generationPoint.position.z) {
		
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + platformWidth+distanceBetween);

			platformSelector = Random.Range (0, objectpoolerEnemyArray.Length); 
			//Instantiate (thePlatform, transform.position, transform.rotation);

			GameObject newPooledObject = objectpoolerEnemyArray[platformSelector].GetPoolObject ();

			newPooledObject.transform.position = transform.position;
			newPooledObject.transform.rotation = transform.rotation;
			newPooledObject.SetActive (true);
		}
	}
}
