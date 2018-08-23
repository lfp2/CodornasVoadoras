using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fight : MonoBehaviour {

    public AudioSource audioSource;
    
    // Use this for initialization
    void Start () {
        audioSource = this.gameObject.GetComponent<AudioSource>();
        while (!audioSource.isPlaying);
        SceneManager.LoadScene("Decision");
    }
	
}
