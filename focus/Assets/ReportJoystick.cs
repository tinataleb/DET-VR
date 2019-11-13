using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Oculus.Avatar;
     
public class ReportJoystick : MonoBehaviour {
    //public Text JoyText = GameObject.Find("Canvas/Joy Text").GetComponent<Text>();
    public Text JoyText;

    private void Start()
    {
        JoyText.text = "START TEXT";
    }

    public float x = 0.0f;
    public float y = 0.0f;
    public float z = 0.0f;

    public string txt1 = "";
    public string txt2 = "";
    public string txt3 = "";

    public string time = "";

    OVRInput.Controller controller = OVRInput.GetActiveController();
    void Update () {
        //stick = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).y;
        x = OVRInput.GetLocalControllerPosition(controller).x;
        txt1 = x.ToString();
        y = OVRInput.GetLocalControllerPosition(controller).y;
        txt2 = y.ToString();
        z = OVRInput.GetLocalControllerPosition(controller).z;
        txt3 = z.ToString();

        time = Time.time.ToString();
        JoyText.text = time;
    }
}
     