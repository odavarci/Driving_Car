using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private variables
    private float speed = 10.0f;
    private float turnSpeed = 95.0f;
    private float horizontalInput, forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get input from user
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotate vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
