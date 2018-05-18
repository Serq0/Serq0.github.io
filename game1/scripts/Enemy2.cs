using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public int Level;
    public float Speed = 20000;
    public float switchLevelTime = 15;
    public int TIMECHANGE = 15;
    public float seconds;

    public Rigidbody2D Rigid
    {
        get
        {
            return GetComponent<Rigidbody2D>();
        }
    }

    // Use this for initialization
    void Start()
    {
        Level = 0;
    }

    int dir = 1;

    private int range = 10;
    // Update is called once per frame
    void Update()
    {
        Rigid.velocity = Vector2.right * dir * Time.deltaTime * Speed;
        if(dir==1 && transform.position.x > range)
        {
            dir = -1;
        }else if(dir==-1 && transform.position.x < -range)
        {
            dir = 1;
        }

        switchLevelTime -= Time.deltaTime;
        if (switchLevelTime > 0)
        {
            //float minutes = Mathf.Floor(switchLevelTime / 60);
            seconds = Mathf.Floor(switchLevelTime % 60);
            //switchLevelTime.text = " " + minutes.ToString("00") + ":" + seconds.ToString("00");
        }
        else
        {
            Level++;
            switchLevelTime = TIMECHANGE;
        }
    }
}
