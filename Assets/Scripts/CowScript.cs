using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowScript : Jump       // INHERITANCE  
{
    public override void JumpUp()                            // POLYMORPHISM
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
    }
    // Start is called before the first frame update
    void Start()
    {
        
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
