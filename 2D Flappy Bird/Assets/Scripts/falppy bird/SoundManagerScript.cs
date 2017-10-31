using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

	public static AudioClip birdHitSound, birdFlapSound;
	static AudioSource audioSrc;

	// Use this for initialization
	void Start () {
		
		birdHitSound = Resources.Load<AudioClip> ("birdHit");
		birdFlapSound = Resources.Load<AudioClip> ("birdFlap");

		audioSrc = GetComponent<AudioSource> (); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void PlaySound (string clip)
	{
		switch (clip) {
		case "birdHit":
			audioSrc.PlayOneShot (birdHitSound);
			break;
		}
		
	switch (clip) {
		case "birdFlap":
			audioSrc.PlayOneShot (birdFlapSound);
			break;

		}
	}
}
