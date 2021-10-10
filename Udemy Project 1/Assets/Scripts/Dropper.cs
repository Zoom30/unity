using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float timeToWait = 5f;
    MeshRenderer renderer;
    Rigidbody rigidbody;
    void Start()
    {

        /*GetComponent<Rigidbody>().useGravity = false;
         GetComponent<MeshRenderer>().enabled = false;
         */
        rigidbody = GetComponent<Rigidbody>();
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
       if (Time.time > timeToWait)
        {
           renderer.enabled = true;
           rigidbody.useGravity = true;
           
       }
        
    }

    
}
