using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTurret : MonoBehaviour
{
    public float rotationSpeed;
    public float distance;


    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.up, out hit, distance)){
            if(hit.collider != null){
                Debug.DrawLine(transform.position, hit.point, Color.red);
                if (hit.collider.CompareTag("Player")){

                 }
            }else {
                Debug.DrawLine(transform.position, transform.position + transform.up * distance, Color.green);
            }
        }

    }
}
