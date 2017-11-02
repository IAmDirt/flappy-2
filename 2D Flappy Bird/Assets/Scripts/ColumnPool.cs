using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour {

	public int columnPoolSize = 5;
	public GameObject columnsPrefab;
	public float spawnRate = 4.0f;
	public float columnMin = -1.0f;
	public float columnMax = 3.5f;

	private GameObject[] columns; //sjå her cecilie
	private Vector2 objectPoolPosition = new Vector2 (-33f, -25f);
	private float timeSinceLastSpawned; 
	private float spawnXposition = 34f;
	private int currentColumn = 0;


	// Use this for initialization
	void Start () 
	{
		columns = new GameObject[columnPoolSize];
		for (int i = 0; i < columnPoolSize; i++) 
		{
			columns [i] = (GameObject)Instantiate (columnsPrefab, objectPoolPosition, Quaternion.identity); 
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		timeSinceLastSpawned += Time.deltaTime; 

		if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate) 
		{
			timeSinceLastSpawned = 0;
			float spawnYPosition = Random.Range (columnMin, columnMax); 
			columns [currentColumn].transform.position = new Vector2 (spawnXposition, spawnYPosition); 
			currentColumn++;
			if (currentColumn >= columnPoolSize) 
			{
				currentColumn = 0;
			}
		}
	}
}
