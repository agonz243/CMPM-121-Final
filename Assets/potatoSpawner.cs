using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class potatoSpawner : MonoBehaviour
{
    public Transform playerPos;
    public GameObject PotatoPrefab;

    public bool pooped = false;

    public float timer = 3;
    public float stopwatch = 0;
    public float countDown = 0.0f;

    void Update(){
        if (pooped){
            stopwatch += Time.deltaTime;
            countDown = timer-stopwatch;
            if (stopwatch > timer){
                pooped = false;
                stopwatch = 0;
                countDown = 0.0f;
            }
        }
        if ((Input.GetKeyDown(KeyCode.Space)) && (pooped == false)){
            GameObject spawnedPotato = Instantiate(PotatoPrefab, playerPos.position, playerPos.rotation);
            pooped = true;
        }
    }

    void OnGUI(){
        GUIStyle timerButt = new GUIStyle(GUI.skin.button);
        timerButt.fontSize = 20;
        timerButt.normal.textColor = Color.white;
        GUI.Box(new Rect(0, Screen.height-30, Screen.width, 30), "time till next potato poop: " + countDown.ToString("#00"), timerButt);
    }

}
