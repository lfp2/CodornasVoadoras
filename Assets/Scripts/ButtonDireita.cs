using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class ButtonDireita : MonoBehaviour {

	public void changeScene(string sceneName)
	{
        AudioSource audioSource = null;
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if(objs.Length > 0)
        {
            audioSource = objs[0].GetComponent<AudioSource>();
        } 
        Debug.Log("Clicado");
		if (sceneName.Equals("Vitrola") && PlayerPrefs.GetInt("stage") == 2)
		{
            PlayerPrefs.SetInt("stage",3);
            SceneManager.LoadScene("VitrolaOff");
		}
		else if (sceneName.Equals("Vitrola") && PlayerPrefs.GetInt("stage") == 3)
		{
            PlayerPrefs.SetInt("lpInMusicbox", PlayerPrefs.GetInt("lpInHands"));
            SceneManager.LoadScene("Vitrola");
		}
		else if (sceneName.Equals("Vitrola") && PlayerPrefs.GetInt("stage") != 6)
		{
			SceneManager.LoadScene(sceneName);
		}
		else if (sceneName.Equals("Room1"))
		{
			SceneManager.LoadScene(sceneName);
		}
		else if (sceneName.Equals("Room1P"))
		{
			SceneManager.LoadScene(sceneName);
		}
		else if (sceneName.Equals("Room2") && PlayerPrefs.GetInt("stage") >= 3 && (audioSource == null || !audioSource.isPlaying))
		{
			SceneManager.LoadScene(sceneName);
		}
		else if (sceneName.Equals("Room2P") && PlayerPrefs.GetInt("stage") >= 4)
		{
			SceneManager.LoadScene(sceneName);
		}
        else if (sceneName.Equals("Room2P1"))
        {
            SceneManager.LoadScene("Room2P");
        }
        else if (sceneName.Equals("BedroomP"))
        {
            SceneManager.LoadScene(sceneName);
        }
        else if (sceneName.Equals("Intro"))
        {
            SceneManager.LoadScene(sceneName);
        }
		else if (sceneName.Equals("Yes"))
		{
			SceneManager.LoadScene(sceneName);
		}
		else if (sceneName.Equals("No"))
		{
			SceneManager.LoadScene(sceneName);
		}
		else if (sceneName.Equals("Creditos"))
		{
			SceneManager.LoadScene(sceneName);
		}
    }
}
