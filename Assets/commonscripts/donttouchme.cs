using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donttouchme : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            this.GetComponent<BoxCollider2D>().isTrigger=true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }
    
    // Update is called once per frame
    void Update () {
		
	}
}
