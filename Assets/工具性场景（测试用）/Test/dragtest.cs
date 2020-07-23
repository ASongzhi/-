using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragtest : MonoBehaviour {
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="itemdrag"&&collision.gameObject.name=="test")
        {
            Debug.Log("use");
            if (Input.GetMouseButtonUp(0))
            {
                Destroy(collision);
            }
        }
    }
    
}
