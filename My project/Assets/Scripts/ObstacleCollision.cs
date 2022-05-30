using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject canvas;
   // public GameObject player;

    void Start()
    {
        Time.timeScale = 1;
        //player.GetComponent<Rigidbody> rb;
        canvas.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        canvas.SetActive(true);
        Time.timeScale = 0;
            
        
    }
}
