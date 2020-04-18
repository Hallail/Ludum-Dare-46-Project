using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    public float smoothness = 0.5f;
    public Vector3 Offset = new Vector3(0, 5, 0);
    public GameObject target;
    private Transform transform;

    void Start()
    {
        transform = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        transform.position =
            Vector3.Lerp(target.transform.position, transform.position, smoothness)
            + Offset;
    }
}
