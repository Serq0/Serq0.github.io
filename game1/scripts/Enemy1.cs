using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {

    public float Speed = 1.0f;
    public float maxy = 8.0f;
    public float maxx = 10.0f;
    public float minspeed = 1.0f;
    public float maxspeed = 60.0f;
    public float maxscale = 6.0f;

    public Rigidbody2D Rigid
    {
        get
        {
            return GetComponent<Rigidbody2D>();
        }
    }

    // Use this for initialization
    void Start () {
        Speed = Random.Range(minspeed, maxspeed);
	}
	
	// Update is called once per frame
	void Update () {
        Rigid.velocity = Vector2.down * Time.deltaTime * Speed;

        if(transform.position.y < -maxy)
        {
            Speed = Random.Range(minspeed, maxspeed);
            transform.position = new Vector2(Random.Range(-maxx, maxx), maxy);
            float randscale = Random.Range(0.5f, maxscale);
            transform.localScale = new Vector2(randscale, randscale);
        }
	}
}
