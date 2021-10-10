using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        processThrust();
    }




    void processThrust() {
        if (Input.GetKey(KeyCode.Space))
        {
            print("Thrusting");
            rb.AddRelativeForce(Vector3.up);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            print("Rotaing Left");
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            print("Rotaing Right");

        }
    }


    void processRotation() {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.UpArrow))
        {
            print("Rotating Left");
        }
        else if (Input.GetKey(KeyCode.D)) {
            print("Rotating Right");
        }
    }
}
