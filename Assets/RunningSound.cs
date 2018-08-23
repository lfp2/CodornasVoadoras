using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using UnityEngine;

public class RunningSound : MonoBehaviour
{
	public Animator anim;
	
	void Update () {
		GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
		AudioSource audioSource = null;
		if(objs.Length > 0){
			audioSource = objs[0].GetComponent<AudioSource>();
		}

		if (audioSource.isPlaying)
		{
			anim.SetTrigger("Run");
		}
	}
}
