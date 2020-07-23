using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showmessage : MonoBehaviour {
    public Text messge;
    public string texttoshow;
    private void Start()
    {
        messge.text = "";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        messge.text = texttoshow;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        messge.text = "";
    }
}
