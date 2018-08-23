using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    public float StartTime;
    private float CurrentTime;
    private Text CountdownText;


	// Use this for initialization
	void Start () {
        CurrentTime = StartTime;
        CountdownText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if(CurrentTime > 0)
        {
            CurrentTime -= Time.deltaTime;
            CountdownText.text = "" + ((int)CurrentTime);
        } 

      /*  if(CurrentTime == 0)
        {
            SceneManager.LoadScene(EndNo);
        }
        */
	}
}
