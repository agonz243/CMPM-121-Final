using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sauceCollide : MonoBehaviour
{
    public float targetTime = 3.0f;
    public bool puddle = false;
    public bool samePud = true;

    public playerMovement player;
    public ParticleSystem ps;
    public AudioSource source;
    public AudioClip clip;
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
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
                player.speed -= 20.0f;
                targetTime = 3.0f;
                ps.Stop();
                ps.Clear();
            }
        } else {
            ps.Stop();
            source.Stop();
        }
    }

    void OnTriggerEnter(Collider collision){
        // Debug.Log(collision.gameObject.name);
        if ((collision.gameObject.name == "boysenchild") && samePud){
            player.speed += 20.0f;
            puddle = true;
            samePud = false;
            ps.Play();
            source.PlayOneShot(clip);
        }
    }
}
