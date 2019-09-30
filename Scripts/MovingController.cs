using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2;
    int direc = 0;
    int ran = 1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        direc += (int)Time.deltaTime;
        if(direc % 3 == 0)
        {
            ran = ran * direc % 3;
        }
        transform.Translate(speed * Time.deltaTime, speed * Time.deltaTime, 0);
        Debug.Log(transform.position.x);
        Debug.Log(transform.position.y);
        if( transform.position.x <= -6.2)
        {
            transform.Rotate(0, 0, 38 * Time.deltaTime);
        }
        else if( transform.position.x >= 6.2)
        {
            //transform.Translate(-speed * Time.deltaTime, speed * Time.deltaTime, 0);
            transform.Rotate(0, 0, 38 * Time.deltaTime);
        }
        else if(transform.position.y <= 0){
            //transform.Translate(speed * Time.deltaTime, -speed * Time.deltaTime, 0);
            transform.Rotate(0, 0, 38 * Time.deltaTime);
        }
        else if(transform.position.y >= 8)
        {
            //transform.Translate(speed * Time.deltaTime, -speed * Time.deltaTime, 0);
            transform.Rotate(0, 0, 38 * Time.deltaTime);
        }
    }
}
