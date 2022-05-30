using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject player;
    public GameObject RespawnPoint;
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        player.transform.position = RespawnPoint.transform.position;  

    }
}
