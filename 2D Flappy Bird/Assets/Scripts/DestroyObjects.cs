using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour {


	void OnCollisionStay2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "platform") {
			Debug.Log ("I CRASH I KILL"); 
			Destroy (coll.gameObject);
		}
	}
}
