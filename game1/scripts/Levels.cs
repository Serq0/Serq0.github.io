using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour {
    public int TIMECHANGE = 5;
    public int Level;
    public float switchLevelTime;

    public int getLevel()
    {
        return Level;
    }

	// Use this for initialization
	void Start () {
        Level = 0;
        switchLevelTime = TIMECHANGE;
	}
	
	// Update is called once per frame
	void Update () {

        switchLevelTime -= Time.deltaTime;
        if (switchLevelTime > 0)
        {
            //float minutes = Mathf.Floor(switchLevelTime / 60);
            float seconds = Mathf.Floor(switchLevelTime % 60);
            //switchLevelTime.text = " " + minutes.ToString("00") + ":" + seconds.ToString("00");
        }
        else
        {
            Level++;
            switchLevelTime = TIMECHANGE;
        }

    }
}
