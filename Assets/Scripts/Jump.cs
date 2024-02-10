using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private bool isOnGround = true;
    public GameObject ground; 
    public int weight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision other)
    {
        isOnGround = true;
    }

    public void JumpUp()
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
