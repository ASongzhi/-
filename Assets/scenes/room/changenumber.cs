using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changenumber : MonoBehaviour {
    public int number;
    public Text text;

    

    private void Update()
    {
        text.text = "" + number;
    }
    private void Start()
    {
        number = 1;
    }
    public void plus()
    {
        if (number == 9)
        {
            number = 0;
        }
        else
        {
            number++;
        }
    }

    public void  minus()
    {
        if (number==0)
        {
            number = 9;
        }
        else
        {
            number--;
        }
    }
}
