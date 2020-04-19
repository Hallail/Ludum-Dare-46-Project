using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    Transform transform;
    public float speed = 10;
    public float jumpForce = 5;
    public bool grounded = true;
    public Collider groundDetect;

    void Start()
    {
        transform = GetComponent<Transform>();
        groundDetect = GetComponent<Collider>();
    }

    void FixedUpdate()
    {
        //basic movement
        float vx = Input.GetAxis("Horizontal");
        float vy = Input.GetAxis("Vertical");
        Vector3 delta = new Vector3(vx * speed * Time.deltaTime, 0, vy * speed * Time.deltaTime);
        transform.position += delta;

        if (Input.GetButton("Jump") & grounded)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpForce, 0);
        }
    }
}
