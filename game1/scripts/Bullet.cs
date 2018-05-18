using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float Speed = 200;
    private int range = 10;

    public Rigidbody2D Rigid
    {
        get
        {
            return GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update () {
        Rigid.velocity = transform.up * Time.deltaTime * Speed;

        if(transform.position.y < -range)
        {
            Destroy(gameObject);
        }
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (tag == other.tag)
        {
            //Destroy(other.gameObject);
            Destroy(gameObject);
        }else return;
        
        
    }
}
