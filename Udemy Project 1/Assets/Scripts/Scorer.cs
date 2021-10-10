using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int touchCounter = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit"){
        Debug.Log("You have bumped into a thing "+ touchCounter++);
        }
        

        
    }

   private void OnCollisionExit(Collision other) {
       GetComponent<MeshRenderer>().material.color = Color.cyan;
   }

   private void OnCollisionStay(Collision other) {
       GetComponent<MeshRenderer>().material.color = Color.black;
   }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
