using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float speed;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)){transform.Translate(transform.right*speed* Time.deltaTime);
        } else if(Input.GetKey(KeyCode.A)){
            transform.Translate(transform.left*speed* Time.deltaTime*-1);
        }
        
    }
}
