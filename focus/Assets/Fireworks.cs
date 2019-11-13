using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

public class Fireworks : MonoBehaviour
{

    public float timestamp;
    public float delay = 30f;
    public GameObject block;

    public float x = 10.0f;
    public float z = 0.0f;
    public float y = 10.0f;

    public bool fire = false;

    void Start()
    {
        timestamp = Time.time;
    }

    void Update()
    {
        if (Time.time > delay)
        {
            if (fire == false)
            {
                Instantiate(block, new Vector3(x, y, z), Quaternion.identity);
                timestamp = Time.time;
            }
            else
            {
                fire = true;
            }
        }
    }
}
