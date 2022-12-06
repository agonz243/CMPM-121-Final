// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class potatoCollide : MonoBehaviour
{
    public NavMeshAgent agent;
    // public Vector3 velocity = agent.velocity;
    public float targetTime = 3.0f;
    public bool hit = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hit){
            targetTime -= Time.deltaTime;
            if (targetTime <= 0.0f){
                hit = false;
                agent.speed += 50.0f;
                targetTime = 3.0f;
            }
        }
    }

    void OnTriggerEnter(Collider collision){
        if (collision.gameObject.name == "potatoPoop(Clone)"){
            agent.speed -= 50.0f;
            hit = true;
            Destroy(collision.gameObject);
        }
    }
}
