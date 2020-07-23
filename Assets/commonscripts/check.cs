using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class check : MonoBehaviour {
    public Text a, b, c, message;
    public Flowchart use;
    public void numcheck()
    {
        if (a.text == "1" && b.text == "0" && c.text == "3")
        {
            message.text = "打开了";
            use.SetBooleanVariable("isdeskopen",true);
        }
        else
        {
            message.text = "不正确";
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
