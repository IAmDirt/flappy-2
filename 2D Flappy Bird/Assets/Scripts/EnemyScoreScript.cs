using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScoreScript : MonoBehaviour {

	private static int score;

	void Update()
	{
		score = GameControl.scoreAll;
	}


	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "droplet") 
		{
			Debug.Log ("fugl død");
			score++;
			Destroy(gameObject);
		}
}
}
