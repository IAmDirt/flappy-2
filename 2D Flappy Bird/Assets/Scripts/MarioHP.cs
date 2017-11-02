using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioHP : MonoBehaviour {
	private Animator anim;

	private float MarioLiv = 6;

	// Use this for initialization
	void Start () {


		anim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {



	}
	IEnumerator vent()
	{
		yield return new WaitForSeconds (0.2f);

		Destroy(gameObject);
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "droplet") 
		{
			Debug.Log ("dø mario");
			MarioLiv--;

			if (MarioLiv < 1) 
			{
				anim.SetTrigger ("PacManDie 0");
				StartCoroutine (vent ());
			}

		}
	}

}
