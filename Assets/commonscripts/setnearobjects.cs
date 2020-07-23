using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class setnearobjects : MonoBehaviour {
    public Flowchart[] clickablesprites;
    

    public string[] tags;
    public int[] tag_values;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player")
        {
            foreach (Flowchart p in clickablesprites)
            {
                for (int i=0;i<tags.Length;i++)
                {
                    if (tag_values[i]==0)
                    {
                        p.SetBooleanVariable(tags[i],false);
                    }
                    else
                    {
                        p.SetBooleanVariable(tags[i], true);
                    }
                }
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            foreach (Flowchart p in clickablesprites)
            {
                for (int i = 0; i < tags.Length; i++)
                {
                    if (tag_values[i] == 0)
                    {
                        p.SetBooleanVariable(tags[i], false);
                    }
                    else
                    {
                        p.SetBooleanVariable(tags[i], true);
                    }
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            foreach (Flowchart p in clickablesprites)
            {
                for (int i = 0; i < tags.Length; i++)
                {
                    if (tag_values[i] == 0)
                    {
                        p.SetBooleanVariable(tags[i], true);
                    }
                    else
                    {
                        p.SetBooleanVariable(tags[i], false);
                    }
                }
            }
        }
    }
}
