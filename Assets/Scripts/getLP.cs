using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class getLP : MonoBehaviour {

	// Use this for initialization
	public void get(int LP){
        AudioSource audioSource= null;
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if(objs.Length > 0)
        {
            audioSource = objs[0].GetComponent<AudioSource>();
        }
        

        if (LP == 4)
        {
            Debug.Log("Botão Pega");
            PlayerPrefs.SetInt("lpInHands", LP);
            PlayerPrefs.SetInt("stage", 7);
            SceneManager.LoadScene("Bedroom");
        }

        else if (PlayerPrefs.GetInt("stage") == 1 && !audioSource.isPlaying)
		{
            if (objs.Length > 0)
            {
                Destroy(objs[0]);
            }
			PlayerPrefs.SetInt("lpInHands", LP);
			SceneManager.LoadScene("Room1P");
			PlayerPrefs.SetInt("stage",2);
		}
        
    }
}
