using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class talk : MonoBehaviour {
    public Flowchart talkflow;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButton("Fire3"))
        {
            talkflow.gameObject.SetActive(true);
        }
    }
}
