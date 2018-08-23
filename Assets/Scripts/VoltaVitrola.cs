using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltaVitrola : MonoBehaviour
{

    public void changeScene()
    {
        if (PlayerPrefs.GetString("timeline").Equals("past")){
            SceneManager.LoadScene("Room1");
        }
        else
        {
            SceneManager.LoadScene("Room1P");
        }
    }
}
