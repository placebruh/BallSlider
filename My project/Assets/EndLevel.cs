using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public GameObject panel;
   // public GameObject player;

    void Start()
    {
        //player.GetComponent<Rigidbody> rb;
        panel.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        panel.SetActive(true);
        //Time.timeScale = 0.;
            
        
    }
}
