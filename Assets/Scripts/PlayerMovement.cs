using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 

    private Rigidbody rb;
    private Vector3 movement;
    public bool canMove=true;

    void Start()
    {
   
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
       
        float moveX = Input.GetAxis("Horizontal"); 
        float moveZ = Input.GetAxis("Vertical");  

      
       
        movement = new Vector3(moveX, 0f, moveZ);
    }   
    void FixedUpdate()
    {
      
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    
        if(canMove==false)
        {
            moveSpeed=0f;
        }
        else
        {
            moveSpeed=5f;
        }
    }

   
}

