using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movementForceMultiplier=1;
    public float jumpForceMultiplier=1;
    
    void Update()
    {
        Vector2 force=Vector2.zero;
       if(Input.GetKey(KeyCode.LeftArrow))
        {
            force.x -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            force.x += 1;
        }
        
        rb.AddForce(force*movementForceMultiplier);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector2.up*jumpForceMultiplier, ForceMode2D.Impulse);
        }
     
    }
}
