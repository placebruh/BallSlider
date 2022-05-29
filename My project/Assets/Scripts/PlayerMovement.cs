using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    
    public float leftRightSpeed;
    public float playerSpeed;

    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void MoveBall()
    {

        Vector3 pos = rb.position;
        if (pos.x < -3)
        {
            rb.velocity = Vector3.right * leftRightSpeed;
            Debug.Log("Idem u desno");

        }

        else if (pos.x > 3)
        {
            rb.velocity = -Vector3.right * leftRightSpeed;
            Debug.Log("Idem u levo");

        }

    }

    void Update()
    {
        MoveBall();
        if (Input.GetMouseButton(0))
        {
            rb.AddForce(Vector3.forward * playerSpeed);
        }
        else
        {
            MoveBall();       
        }
    }
}