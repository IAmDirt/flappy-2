using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioHp : MonoBehaviour {
	private Animator anim;
	private float MarioLiv = 4;
	private Rigidbody2D rb2d; 

	public float upForce = 200f;
	// Use this for initialization
	void Start () {

		rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();

	}
		
	IEnumerator vent()
	{
		yield return new WaitForSeconds (0.1f);

		Destroy(gameObject);
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "droplet") 
		{
			Debug.Log ("dø Mario");
			MarioLiv--;

			if (MarioLiv < 1) 
			{
				StartCoroutine (vent ());
			}

		}
		if (coll.gameObject.tag == "platform")
		{
			rb2d.AddForce (new Vector2 (0, upForce));
		}
		if (coll.gameObject.tag == "lava")
		{
			Destroy(gameObject);
		}
	}

}
