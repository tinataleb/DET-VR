using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

public class Expanding : MonoBehaviour
{

    public float timestamp;
    public float inhale_delay = 3.0f;
    public float exhale_delay = 6.0f;

    public float x = 0.1f;
    public float z = 0.1f;
    public float y = 0.1f;

    public bool expand = true;

    void Start()
    {
        timestamp = Time.time;
    }

    void Update()
    {
        if ((Time.time - timestamp) > delay)
        {
            if (expand == true)
            {
                transform.localScale += new Vector3(x, y, z);
                timestamp = Time.time;
                expand = false;
            }
            else
            {
                transform.localScale -= new Vector3(x, y, z);
                timestamp = Time.time;
                expand = true;
            }
        }
    }
}
