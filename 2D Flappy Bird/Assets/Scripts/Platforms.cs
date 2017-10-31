using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour {

	public GameObject Ground;


	void Start() 
	{
		RandomMapBuilder();
	}


	void RandomMapBuilder()
	{
		for (int i = 0; i < 20; i++) {
			Vector3 SpawnPosition = new Vector3 (21, Random.Range (-3, 2), 0);
			Instantiate (GameObject.Find("Ground"), SpawnPosition, Quaternion.identity); 
		}
	}
}