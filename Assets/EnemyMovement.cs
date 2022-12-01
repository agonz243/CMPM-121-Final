
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public NavMeshAgent agent;
    public GameObject player;
    private Vector3 playerPos;


    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;
        agent.SetDestination(playerPos);
    }
}
