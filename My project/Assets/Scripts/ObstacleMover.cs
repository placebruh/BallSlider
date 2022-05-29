using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    [SerializeField]
    private Animation anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        anim.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
