using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        PrintSomeString();
    }

    // Update is called once per frame
    void Update()
    {

        MovePlayer();
        
       
    }

    void PrintSomeString() {
        Debug.Log("Run successfully");
        Debug.Log("Move your player with WASD");
        Debug.Log("Dont hit the wall");

    }

    void MovePlayer() {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
         

        transform.Translate(xValue, 0, zValue);

    }

}
