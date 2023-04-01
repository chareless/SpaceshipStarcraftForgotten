using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public int speed;
    void Start()
    {
        speed = 3;
    }

    void Move()
    {
        transform.position -= new Vector3(speed,0,0)*Time.deltaTime;
        if(transform.position.x < -33)
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }

    void Update()
    {
        Move();
    }
}
