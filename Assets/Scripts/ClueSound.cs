using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueSound : MonoBehaviour {

    public AudioSource audioSource;

    // Use this for initialization
    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void OnMouseEnter()
    {
        //Debug.Log("zaga");
        audioSource.Play();

    }

}
