using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    Transform transform;
    public float speed = 10;
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float vx = Input.GetAxis("Horizontal");
        float vy = Input.GetAxis("Vertical");
        Vector3 delta = new Vector3(vx * speed * Time.deltaTime, 0, vy * speed * Time.deltaTime);
        transform.position += delta;
    }
}
