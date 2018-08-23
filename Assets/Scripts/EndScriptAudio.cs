using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScriptAudio : MonoBehaviour {

    public AudioSource audioSource1;
	public AudioSource audioSource2;
    public AudioClip[] MusicClip1;

    // Use this for initialization
    void Start () {
        audioSource1.GetComponent<AudioSource>();
	    audioSource1.clip = MusicClip1[0];
	    audioSource1.Play();
	    audioSource2.clip = MusicClip1[1];
	    audioSource2.Play();
	}
	
}
