using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room1patch : MonoBehaviour {

	// Use this for initialization
	void Start () {
        isactive = true;
	}
	public GameObject[] line;
    public bool isactive;

    public void Onclick()
    {
        isactive = !isactive;
    }

    
	// Update is called once per frame
	void LateUpdate () {
        foreach (GameObject p in line)
        {
            p.gameObject.SetActive(isactive);
        }
	}
}
