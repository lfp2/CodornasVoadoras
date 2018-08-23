using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class AudioScript : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioSource auxSource;
    public AudioClip[] MusicClip;
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

// Use this for initialization
    void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        DontDestroyOnLoad(objs[0]);
        GameObject[] messages = GameObject.FindGameObjectsWithTag("messages");
        DontDestroyOnLoad(messages[0]);
    }

    public void resumeOrPause()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        audioSource = objs[0].GetComponent<AudioSource>();
        GameObject[] messages = GameObject.FindGameObjectsWithTag("messages");
        auxSource = messages[0].GetComponent<AudioSource>();
        auxSource.volume = 1 - audioSource.volume;
        if (PlayerPrefs.GetInt("stage") == 4)
        {
            audioSource.Stop();
            auxSource.clip = MusicClip[3];
            PlayerPrefs.SetInt("stage", 5);
            PlayerPrefs.SetString("timeline", "present");
            audioSource.Play();
        }
        else if (PlayerPrefs.GetInt("stage") == 5)
        {
            PlayerPrefs.SetInt("stage", 6);
            SceneManager.LoadScene("VitrolaOff");
        }
        else if (!audioSource.isPlaying)
        {
            Debug.Log(PlayerPrefs.GetInt("lpInHands"));
            audioSource.clip = MusicClip[PlayerPrefs.GetInt("lpInMusicbox")];
            audioSource.Play();
            if (PlayerPrefs.GetInt("stage") <= 1)
            {
                auxSource.clip = MusicClip[1];
                //Debug.Log("AuxSource");
                auxSource.Play();
            }
            PlayerPrefs.SetString("timeline", "past");
            
        }
        else
        {
            Debug.Log("Pausar");
            audioSource.Stop();
            if (PlayerPrefs.GetInt("stage") <= 1)
            {
                //.Log("AuxSource");
                auxSource.Stop();
            }
        }
    }

    public void lowVolume()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        audioSource = objs[0].GetComponent<AudioSource>();
        GameObject[] messages = GameObject.FindGameObjectsWithTag("messages");
        auxSource = messages[0].GetComponent<AudioSource>();
        if (PlayerPrefs.GetFloat("volume") == 1)
        {
            Debug.Log("Volume 0.5");
            PlayerPrefs.SetFloat("volume", 0.5f);
            audioSource.volume = 0.5f;
            auxSource.volume = 0.5f;
        }else if (PlayerPrefs.GetFloat("volume") == 0.5f)
        {
            Debug.Log("Volume 0.25");
            PlayerPrefs.SetFloat("volume", 0f);
            audioSource.volume = 0.25f;
            auxSource.volume = 1;
            if (PlayerPrefs.GetInt("stage") < 1)
            {
                PlayerPrefs.SetInt("stage",1);
            }
        }
    }
    
    public void highVolume()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        audioSource = objs[0].GetComponent<AudioSource>();
        GameObject[] messages = GameObject.FindGameObjectsWithTag("messages");
        auxSource = messages[0].GetComponent<AudioSource>();
        if (PlayerPrefs.GetFloat("volume") == 0f)
        {
            Debug.Log("Volume 0.5");
            PlayerPrefs.SetFloat("volume", 0.5f);
            audioSource.volume = 0.5f;
            auxSource.volume = 0.5f;
        }else if (PlayerPrefs.GetFloat("volume") == 0.5f)
        {
            Debug.Log("Volume 1");
            PlayerPrefs.SetFloat("volume", 1);
            audioSource.volume = 1;
            auxSource.volume = 0f;
        }
    }
}