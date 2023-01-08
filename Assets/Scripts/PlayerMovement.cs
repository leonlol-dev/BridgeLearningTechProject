using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    public float force = 25;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {  
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 playerMovement = new Vector3(horizontal, 0.0f, vertical);
        Vector3 moveVector = transform.TransformDirection(playerMovement) * speed;
        rb.velocity = new Vector3(moveVector.x, rb.velocity.y, moveVector.z);   
        //transform.Translate(playerMovement, Space.Self);
        //rb.AddForce(playerMovement);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Score")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(collision.rigidbody.velocity.normalized * force);
        }

   
    }

    
}
