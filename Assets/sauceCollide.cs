using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sauceCollide : MonoBehaviour
{
    public float targetTime = 3.0f;
    public bool puddle = false;
    public bool samePud = true;

    public playerMovement player;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (puddle){
            targetTime -= Time.deltaTime;
            if (targetTime <= 2.0f){
                samePud = true;
            }
            if (targetTime <= 0.0f){
                puddle = false;
                player.speed -= 10.0f;
                targetTime = 3.0f;
            }
        }
    }

    void OnTriggerEnter(Collider collision){
        // Debug.Log(collision.gameObject.name);
        if ((collision.gameObject.name == "boysenchild") && samePud){
            player.speed += 10.0f;
            puddle = true;
            samePud = false;
        }
    }
}
