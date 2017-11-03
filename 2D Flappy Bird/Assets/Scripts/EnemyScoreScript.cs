using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScoreScript : MonoBehaviour {

	private static int score;

	void Update()
	{
		score = GameControl.scoreAll;
		score++;
	}


	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "platform")
		{
			Destroy(gameObject);		
		}
		if (coll.gameObject.tag == "target") 
		{
			Debug.Log ("truffet");
			GameControl.instance.BirdScored ();
			Destroy(gameObject);
		}
}
}
