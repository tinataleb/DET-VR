using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

public class Expanding : MonoBehaviour
{

    public float timestamp;
    public float inhale_delay = 3.0f;
    public float exhale_delay = 9.0f;

    public float expand = 0.06f;
    public float contract = 0.08f;

    void Start()
    {
        timestamp = Time.time;
    }

    void Update()
    {


        if ((Time.time - timestamp) < inhale_delay)
        {
            transform.localScale += new Vector3(expand, expand, expand);
        }
        else if ((Time.time - timestamp) < exhale_delay)
        {
            transform.localScale -= new Vector3(contract, contract, contract);

        }
        else
        {
            timestamp = Time.time;
        }
    }
}
