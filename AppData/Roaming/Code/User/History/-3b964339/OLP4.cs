using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float speed;
     private Rigidbody2D rb;
    // Update is called once per frame
      private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 1f; // set the gravity scale of the top block to non-zero
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.D)){transform.Translate(transform.right*speed* Time.deltaTime);
        } else if(Input.GetKey(KeyCode.A)){
            transform.Translate(transform.right*speed* Time.deltaTime*-1);
        } else if(Input.GetKey(KeyCode.Mouse0)){
            transform.Translate(transform.up*speed* -1);
        }
        
    }  private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) 
        {
            rb.gravityScale = 0f;
            rb.isKinematic = true; 
        }
    }
}
