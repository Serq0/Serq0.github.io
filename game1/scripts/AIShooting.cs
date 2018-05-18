using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIShooting : MonoBehaviour {

    public GameObject Bullet;

    float timer = 0;
    float shotTime = 2;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > shotTime)
        {
            timer -= shotTime;
            //set shot time
            shotTime = Random.Range(0.1f,0.7f);

            GameObject go = Instantiate(Bullet);
            //go.transform.position = transform.position;
            go.transform.position = new Vector2(transform.position.x, transform.position.y-1);
            go.transform.eulerAngles = new Vector3(0, 0, 180);
            go.tag = tag;

        }
    }
}
