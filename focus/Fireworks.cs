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
    void Start()
    {
        timestamp = Time.time;
    }

    void Update()
    {
        System.Random random = new System.Random();
        if ((Time.time - timestamp) > delay)
        {
            Instantiate(block, new Vector3(x, y, z), Quaternion.identity);
            timestamp = Time.time;
        }
    }
