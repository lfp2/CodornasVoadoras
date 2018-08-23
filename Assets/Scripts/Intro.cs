using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("knocks", 0);
        PlayerPrefs.SetInt("stage", 0);
        PlayerPrefs.SetInt("lpInHands", 0);
        PlayerPrefs.SetInt("lpInMusicbox", 0);
        PlayerPrefs.SetInt("isPlaying", 0);
        PlayerPrefs.SetFloat("volume", 1);
        PlayerPrefs.SetString("timeline", "present");
        PlayerPrefs.SetInt("stuckMusic", 0);
        PlayerPrefs.SetInt("isKeyDisponible", 0);
        PlayerPrefs.SetInt("withKey", 0);
    }

    public void changeScene()
    {
        Debug.Log("Clicado");
        SceneManager.LoadScene("Room1P");
    }
}
