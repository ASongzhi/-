using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class forest1_trigger_bag : MonoBehaviour {

    public Flowchart flowchart;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        flowchart.SetBooleanVariable("isnearby",true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        flowchart.SetBooleanVariable("isnearby",false);
    }

}
