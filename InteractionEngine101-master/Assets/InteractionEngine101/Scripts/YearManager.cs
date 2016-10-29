using UnityEngine;
using System.Collections;

public class YearManager : MonoBehaviour {
    public float year;
    public float currentYear = 2000f;
    public RotationLogger dead;
	// Use this for initialization
	void Start () {
        GameObject d = GameObject.Find("TestButton");
         RotationLogger dead = d.GetComponent<RotationLogger>();



    }
	
	// Update is called once per frame
	void Update () {
     //   Debug.Log(currentYear);

   
    }
}
