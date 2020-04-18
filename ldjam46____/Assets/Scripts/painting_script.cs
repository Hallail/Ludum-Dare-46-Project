using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class painting_script : MonoBehaviour
{
    Transform transform;
    public GameObject player;
    public float distanceFromPlayer;
    bool following = false;
    public float rotateSpeed = 5;
    public float smoothness = 0.25f;

    void Start()
    {
        transform = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        transform.Rotate(0, rotateSpeed, 0);
        if (following)
        {
            Vector3 displacement = player.transform.position - transform.position;
            if (displacement.magnitude > distanceFromPlayer)
            {
                Vector3 followPoint = displacement.normalized * distanceFromPlayer;
                transform.position = Vector3.Lerp(player.transform.position + followPoint, transform.position, smoothness);
            }
        }
    }

    void OnTriggerEnter(Collider o)
    {
        following = true;
    }
}
