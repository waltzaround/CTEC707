using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RotationLogger : MonoBehaviour {

    public GameObject textgameobject;//set this is inspector or by script, maybe GameObject.Find or something, idk.

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {



        HingeJoint hinge = gameObject.GetComponent(typeof(HingeJoint)) as HingeJoint;


        Canvas canvas = gameObject.GetComponent(typeof(Canvas)) as Canvas;

        Text text = gameObject.GetComponent(typeof(Text)) as Text;
        hinge.angle.ToString() = text;

        var weightfield = GameObject.Find("CurrentValue").GetComponent("TextMesh");
        weightfield.text = totalWeight;

    }

       
    void Foo()
    {
        Text text = textgameobject.GetComponent<Text>(); //get the text component in the gameobject you assigned
        text.text = "insert some text here"; //set the text in the text component
    }




}

