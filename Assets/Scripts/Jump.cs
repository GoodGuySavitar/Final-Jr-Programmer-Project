using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour                
{
    public bool isOnGround = true;
    public GameObject ground;
    public int weight { get; set; }          // ENCAPSULATION 
    // Start is called before the first frame update
    void Start()
    {
        weight = 200;
    }

    public void OnCollisionEnter(Collision other)
    {
        isOnGround = true;
    }

    public void JumpUp()                                                      // ABSTRACTION  
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * weight);
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnGround && Input.GetKeyDown(KeyCode.Space))
        {
            JumpUp();
            isOnGround = false;
        }
    }
}
