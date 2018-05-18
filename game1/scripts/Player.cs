using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float Speed = 300;
    public GameObject Bullet;
    public Levels Levels;
    float xmap, ymap, diff;

    public Rigidbody2D Rigid {
        get {
            return GetComponent<Rigidbody2D>();
        }
    }

	// Use this for initialization
	void Start () {
        xmap = 8.6f;
        ymap = 4.7f;
        diff = 0.001f;
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 vel = new Vector2(0,0);
        if (transform.position.x < 10 && transform.position.x > -10 && transform.position.y < 5 && transform.position.y > -5)
        {
            vel = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            vel *= Time.deltaTime;
            vel *= Speed;
        }
        
            if(transform.position.x >= xmap)
            {
                transform.position = new Vector2(xmap-diff, transform.position.y);
            }
            if(transform.position.x <= -xmap)
            {
                transform.position = new Vector2(-xmap+diff, transform.position.y);
            }
            if(transform.position.y >= ymap)
            {
                transform.position = new Vector2(transform.position.x, ymap-diff);
            }
            if(transform.position.y <= -ymap)
            {
                transform.position = new Vector2(transform.position.x, -ymap+diff);
            }
        
        

        Rigid.velocity = vel;
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(Bullet);
            go.transform.position = transform.position;
            go.tag = tag;
        }
        */
	}
}
