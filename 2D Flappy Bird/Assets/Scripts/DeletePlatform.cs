﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlatform : MonoBehaviour {


	void OnCollisionEnter2D(Collision2D coll)
	{

		if (coll.gameObject.tag == "platform") 
		{
			Debug.Log ("ICE CREAM");
			Destroy(gameObject);
		}
	}
}
