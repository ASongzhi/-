using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class bag_switch : MonoBehaviour {
    public bool is_bag_open =false;
    public GameObject bar;

    private void Start()
    {
        is_bag_open = false;
    }

    public void OnClick()
    {
        is_bag_open = ! is_bag_open;
    }

    private void Update()
    {
        if (Input.GetKeyUp("b"))
        {
            is_bag_open = !is_bag_open;
        }

        if (is_bag_open)
        {
            bar.SetActive(true);
        }
        else
        {
            bar.SetActive(false);
        }
    }
}
