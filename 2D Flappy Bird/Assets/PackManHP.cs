using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackManHP : MonoBehaviour {
	private Animator anim;

	private float PackManLiv = 2;

	// Use this for initialization
	void Start () {


		anim = GetComponent<Animator> ();
	
	}

	// Update is called once per frame
	void Update () {



	}
	IEnumerator vent()
	{
		yield return new WaitForSeconds (0.7f);

		Destroy(gameObject);
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "droplet") 
		{
			Debug.Log ("dø pack man");
			PackManLiv--;

			if (PackManLiv < 1) 
			{
				anim.SetTrigger ("PacManDie 0");
				StartCoroutine (vent ());
			}

		}
}

}
