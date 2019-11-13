using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using Oculus.Avatar;

public class Haptics : MonoBehaviour
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
            OVRInput.SetControllerVibration(0.9f, 0.1f, OVRInput.Controller.RTouch);
            OVRInput.SetControllerVibration(0.9f, 0.1f, OVRInput.Controller.LTouch);
        }
        else if ((Time.time - timestamp) < exhale_delay)
        {
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.RTouch);
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.LTouch);

        }
        else
        {
            timestamp = Time.time;
        }
    }
}
