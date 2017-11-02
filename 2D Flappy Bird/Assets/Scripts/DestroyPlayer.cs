using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour {

	public GameObject Bird; 

	void OnCollisionStay2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Player") {
			Debug.Log ("I CRASH I KILL"); 
			Destroy (Bird);
		}
	}
}
