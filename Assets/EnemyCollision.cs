using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider collision) {
        if(collision.GetComponent<Collider>().tag == "Player")
        {
            Debug.Log("Collided with player");
            SceneManager.LoadScene(1);
        }
    }
}
