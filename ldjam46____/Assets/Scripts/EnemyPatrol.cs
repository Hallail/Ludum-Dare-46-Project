using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyPatrol : MonoBehaviour
{

    public float speed;
    private float waitTime;
    public float startWaitTime;

    public Transform moveSpot;

    public float minX;
    public float maxX;
    public float posY;

    void Start()
    {
        waitTime = startWaitTime;

        moveSpot.position = new Vector2(Random.Range(minX, maxX), posY);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpot.position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, moveSpot.position) < 0.2f){
            if(waitTime <= 0){
                moveSpot.position = new Vector2(Random.Range(minX, maxX), posY);
                waitTime = startWaitTime;
            }else{
                waitTime -= Time.deltaTime;
            }
        }
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player")
        SceneManager.LoadScene("Dead");
    }
}
