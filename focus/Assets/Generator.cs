using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

public class Generator : MonoBehaviour {

    public float timestamp;
    public float delay = 8f;
    public GameObject red_block;
    public GameObject blue_block;
    public GameObject green_block;

    public float x = 0.0f;
    public float z = 0.4f;
    public float y = 0.2f;
    public float increment = 0.0f;
    public float rand_z = 0;
    public float rand_x = 0;

    public int color = 0;
    public bool flip = false;


    void Start()
    {
        timestamp  = Time.time;
    }

    void Update()
    {
        System.Random random = new System.Random();
        rand_x = random.Next(-1000, 1000)/100;
        rand_z = random.Next(-1000, 1000)/100;

        color = random.Next(0, 3);



        if (flip == false)
        {
            if (Time.time >= 4.0f)
            {
                flip = true;
                timestamp = Time.time;
            }
        }
        else
        {

            if ((Time.time - timestamp) > delay)
            {
                if (color == 0)
                {
                    Instantiate(red_block, new Vector3(x, y, z), Quaternion.identity);
                }
                else if (color == 1)
                {
                    Instantiate(green_block, new Vector3(x, y, z), Quaternion.identity);
                }
                else
                {
                    Instantiate(blue_block, new Vector3(x, y, z), Quaternion.identity);
                }
                timestamp = Time.time;
            }
        }
    }
} 