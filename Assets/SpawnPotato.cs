using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPotato : MonoBehaviour
{
    public Transform playerPos;
    // Vector3 playerPos = player.transform.position;
    // Vector3 playerDirection = player.transform.forward;
    public GameObject PotatoPrefab;

    // private bool waitForButton;
    // public bool requireButton;

    void update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("pressed space");
            Instantiate(PotatoPrefab, playerPos.position - playerPos.forward * 5, playerPos.rotation);
        }
    }

    // void OnTriggerEnter (){
    //     if (requireButton){
    //         waitForButton = true;
    //         return;
    //     }
    // }
}
