using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private float horizontalInput;
    private bool jumpKeyWasPressed;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }
        horizontalInput = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontalInput * 8, rb.velocity.y, 0);
        if (!isGrounded)
        {
            return;
        }
        if (jumpKeyWasPressed)
        {
            rb.AddForce(Vector3.up*10, ForceMode.VelocityChange);
            jumpKeyWasPressed=false;
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
