using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Rigidbody worldRb;
    public GameObject world;
    public float speed;
    public float worldSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void MoveBall() 
    {

        Vector3 pos = rb.position;
        if (pos.x < -3)
        {
            rb.velocity = Vector3.right * speed ;
            Debug.Log("Idem u desno");

        }

        else if (pos.x > 3)
        {
            rb.velocity = -Vector3.right * speed;
            Debug.Log("Idem u levo");

        }
      
    }

 void Update()
    {
        MoveBall();
        if (Input.GetMouseButton(0))
        {
            worldRb.velocity = Vector3.back * worldSpeed;
        }
        else 
        {
            worldRb.velocity = Vector3.zero;
        }
    }
}
