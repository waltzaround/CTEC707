using UnityEngine;
using System.Collections;

public class YearManager : MonoBehaviour {
    public float year;
    public float currentYear = 2000f;
	// Use this for initialization
	void Start () {
        GameObject theDelta = GameObject.Find("CurrentValue");
        RotationLogger rotationLogger = theDelta.GetComponent<RotationLogger>();


    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("potato");

    //    currentYear = (currentYear - rotationLogger.delta);
    }
}
