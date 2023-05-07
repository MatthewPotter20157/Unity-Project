using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private GameObject player;
    public NavMeshAgent agent;
    public GameObject bullet;
    void Start()
    {
        player = GameObject.Find("Player");
        bullet = GameObject.Find("Bullet");
    }
    void Update()
    {
        gameObject.SetActive(true);
        agent.SetDestination(player.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            LevelGenerator.enemyCount--;
        }
    }
}