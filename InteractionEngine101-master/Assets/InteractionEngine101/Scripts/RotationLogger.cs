using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class RotationLogger : MonoBehaviour {

    public GameObject textgameobject;//set this is inspector or by script, maybe GameObject.Find or something, idk.
    private HingeJoint hinge;
    private float prevAngle;
    public float delta;

    public bool timingStarted = false;
    public DateTime timingStart;

    public bool hasTargetValue = false;
    public double year;
    public int targetYear;
    const int threshHold = 20;
    public int framesMatched = 0;

    public GameObject scoreboard;

    // Use this for initialization
    void Start () {
        // Supa Hax
        var yourTime = GameObject.Find("YourTimeBoard");
        scoreboard = yourTime;
        yourTime.SetActive(false);

        hinge = gameObject.GetComponent(typeof(HingeJoint)) as HingeJoint;
        prevAngle = hinge.angle;
        year = 2000;
        targetYear = 1962;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float angle = hinge.angle;

        delta = angle - prevAngle;
        if (delta > 180) { delta -= 360; }
        if (delta < -180) { delta += 360; }
        
        
        prevAngle = angle;

        // supahax
        const double scale = 0.05;
        double transformedDelta = delta * scale;
        year += transformedDelta;

        // haxx
        GameObject currValue = GameObject.Find("CurrentValue");
        Text textDisplay = currValue.GetComponent("Text") as Text;
        textDisplay.text = "" + (int) year;
        
        if (!timingStarted || hasTargetValue)
        {
            return;
        }

        if ((int)year == targetYear)
        {
            framesMatched += 1;
            if (framesMatched > threshHold)
            {
                DateTime now = DateTime.Now;
                TimeSpan diff = now.Subtract(timingStart);
                Debug.Log(diff.TotalMilliseconds);
                hasTargetValue = true;

                scoreboard.SetActive(true);

                Text display = GameObject.Find("UserTimeDisplay").GetComponent("Text") as Text;
                string displayText = "" + Math.Round(diff.TotalMilliseconds / 1000.0, 2) + " Seconds";
                display.text = displayText;
                
            }
        }
        else
        {
            framesMatched = 0;
        }
    }


    /*
       
    void Foo()
    {
        Text text = textgameobject.GetComponent<Text>(); //get the text component in the gameobject you assigned
        text.text = "insert some text here"; //set the text in the text component
    }
    */



}

