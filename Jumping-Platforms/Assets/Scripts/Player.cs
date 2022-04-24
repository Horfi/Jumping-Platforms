using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded==true)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 10, ForceMode.VelocityChange);
        }
    }
    bool isGrounded = false;
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.contactCount == 1)
        {
            isGrounded=true;
            Debug.Log("1");
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.contactCount == 0)
        {
            isGrounded = false;
            Debug.Log("0");
        }
    }

}
