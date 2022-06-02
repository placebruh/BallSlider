using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    
    public float leftRightSpeed = 5;
    public float playerSpeed;

    Vector3 toAdd;

    void Start()
    {
        toAdd = new Vector3(0,0,0);
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void MoveBall()
    {
        Vector3 pos = rb.position;
        if (pos.x < -3)
        {
            toAdd = new Vector3(leftRightSpeed + rb.velocity.x, rb.velocity.y, rb.velocity.z);//Vector3.right * leftRightSpeed;
            Debug.Log("Idem u desno");

        }

        else if (pos.x > 3)
        {
            toAdd =  new Vector3(-leftRightSpeed + rb.velocity.x, rb.velocity.y, rb.velocity.z);//-Vector3.right * leftRightSpeed;
            Debug.Log("Idem u levo");

        }

        rb.velocity = toAdd;

    }

    void FixedUpdate()
    {
        MoveBall();
        if (Input.GetMouseButton(0))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, playerSpeed);
        }
        else
        {
            rb.velocity =  new Vector3(rb.velocity.x, rb.velocity.y, 0);//-Vector3.right * leftRightSpeed;    
        }
    }
}