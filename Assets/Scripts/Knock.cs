using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Knock : MonoBehaviour{
    public AudioSource audioSource;
    public AudioClip[] MusicClip;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if(MusicClip.Length > 0)
        {
            audioSource.clip = MusicClip[0];
        }
    }

    public void KnockDoor()
    {
        if (PlayerPrefs.GetInt("stage") > 5)
        {
            SceneManager.LoadScene("Bedroom");
        }
        else
        {
            audioSource.Play();
            PlayerPrefs.SetInt("knocks", (PlayerPrefs.GetInt("knocks") + 1));
            Debug.Log(PlayerPrefs.GetInt("knocks"));
            if (PlayerPrefs.GetInt("knocks") >= 3)
            {
                GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
                if(objs.Length >= 1)
                {
                    Destroy(objs[0]);
                }
                GameObject[] messages = GameObject.FindGameObjectsWithTag("messages");
                if (messages.Length >= 1)
                {
                    Destroy(messages[0]);
                }
                audioSource.clip = MusicClip[1];
                PlayerPrefs.SetInt("stage", 4);
                audioSource.Play();
            }
        }
    }

}