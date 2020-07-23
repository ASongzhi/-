using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move : MonoBehaviour {
    public bool istoright=true;
    public float speed;
    Animator animator;
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float movehorizontal = Input.GetAxis("Horizontal");
        

        if (istoright==true&&movehorizontal<0)
        {

            istoright = false;
            GetComponent<SpriteRenderer>().flipX=!GetComponent<SpriteRenderer>().flipX;
        }else if (istoright==false&&movehorizontal>0)
        {
            istoright = true;
            GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
        }
        else { }

        if (movehorizontal!=0)
        {
            animator.SetBool("iswalking",true);
        }
        else
        {
            animator.SetBool("iswalking",false);
        }

        Vector3 movement = new Vector3(movehorizontal, 0.0f, 0.0f);
        if (Input.GetButton("Fire3"))
        {
            movement *= 2;
            animator.SetBool("isrunning",true);
        }
        else
        {
            animator.SetBool("isrunning",false);
        }
        GetComponent<Rigidbody2D>().velocity = movement*speed;
	}


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("floor"))
        {
            Debug.Log("OnCollisionEnter2D OK");
            this.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
            
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("floor"))
        {
            Debug.Log("OnCollisionStay2D OK");
            this.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("OnCollisionExit2D OK");
        this.GetComponent<Rigidbody2D>().gravityScale = 10;
    }
}
