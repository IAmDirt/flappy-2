using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour {

	public int columnPoolSize;
	public GameObject prefab1, prefab2, prefab3;
	public float spawnRate = 4.0f;
	public float columnMin = -1.0f;
	public float columnMax = 3.5f;

	public GameObject[] columns; //sjå her cecilie
	private Vector2 objectPoolPosition = new Vector2 (70f, -2);
	private float timeSinceLastSpawned; 
	private float spawnXposition = 25f; 
	private int currentColumn = 0;

	private int whatToSpawn; 
	private float nextSpawn = 0f;

//	private float SetRandomRange;


	// Use this for initialization3
	void Start () 
	{
//		SetRandomRange = Random.Range (columnMin, columnMax); 
		 
		columns = new GameObject[columnPoolSize];
		for (int i = 0; i < columnPoolSize; i++) 
		{
//			columns [i] = (GameObject)Instantiate (prefab1, objectPoolPosition, Quaternion.identity); 			/////////////////////
		}
	}

	// Update is called once per frame
	void Update () 
	{
		timeSinceLastSpawned += Time.deltaTime; 

		if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate) 
		{
			timeSinceLastSpawned = 0;
			whatToSpawn = Random.Range (1, 4);
			float spawnYPosition = Random.Range (columnMin, columnMax); 
	//		columns [currentColumn].transform.position = new Vector2 (spawnXposition, spawnYPosition); 
			currentColumn++;

			switch (whatToSpawn) {
			case 1:
				Instantiate (prefab1, new Vector2 (spawnXposition, spawnYPosition), Quaternion.identity);
				break;
			case 2: 
				Instantiate (prefab2, new Vector2 (spawnXposition, spawnYPosition), Quaternion.identity);
				break;
			case 3:
				Instantiate (prefab3, new Vector2 (spawnXposition, spawnYPosition), Quaternion.identity);
				break;
			}

			if (currentColumn >= columnPoolSize) 
			{
				currentColumn = 0;
			}
		}
	}
}
