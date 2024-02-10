using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowScript : Jump       // INHERITANCE  
{
    public void JumpUp()                            // POLYMORPHISM
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * weight);
    }
    // Start is called before the first frame update
    void Start()
    {
        weight = 300;
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
