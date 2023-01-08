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
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(horizontal, 0.0f, vertical) * speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Score")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(collision.relativeVelocity.normalized * force);
        }
    }
}
