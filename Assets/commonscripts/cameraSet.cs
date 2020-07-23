using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class cameraSet : MonoBehaviour {

    public Flowchart flowchart;
	// Use this for initialization
	void Start () {
        flowchart.gameObject.SetActive(false);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player")
        {
            flowchart.gameObject.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            flowchart.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag=="Player")
        {
            flowchart.gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
