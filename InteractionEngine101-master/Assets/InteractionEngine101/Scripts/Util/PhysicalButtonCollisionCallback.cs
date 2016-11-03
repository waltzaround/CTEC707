/******************************************************************************\
* Copyright (C) 2012-2016 Leap Motion, Inc. All rights reserved.               *
* Leap Motion proprietary and confidential. Not for distribution.              *
* Use subject to the terms of the Leap Motion SDK Agreement available at       *
* https://developer.leapmotion.com/sdk_agreement, or another agreement         *
* between Leap Motion and you, your company or other organization.             *
\******************************************************************************/

using UnityEngine;
using System.Collections;
using System;

public class PhysicalButtonCollisionCallback : MonoBehaviour {

    public float spinValue;
    public float spinValueDelta;
    private bool havePressed = false;

    void OnCollisionEnter(Collision coll) {
        if (!havePressed)
        {
            havePressed = true;
            DateTime start = System.DateTime.Now;
            var button = GameObject.Find("TestButton") as GameObject;
            var rotationLogger = button.GetComponent(typeof(RotationLogger)) as RotationLogger;
            rotationLogger.timingStarted = true;
            rotationLogger.timingStart = start;
            Debug.Log("Button Pushed, Timing Start");

            
        }
    }

    void Update()
    {
    }

}
