using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class forest2_trigger_rabish : MonoBehaviour {

    public Flowchart flowchart;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            flowchart.SetBooleanVariable("isnearby", true);
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            flowchart.SetBooleanVariable("isnearby", false);
        }
    }
}
