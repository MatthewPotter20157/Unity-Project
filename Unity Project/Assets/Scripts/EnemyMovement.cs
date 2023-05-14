using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private GameObject player;
    public NavMeshAgent agent;
    public GameObject bullet;
    private LevelGenerator levelGenerator;
    void Start()
    {
        player = GameObject.Find("Player");
        bullet = GameObject.Find("Bullet");
        levelGenerator = GameObject.Find("LevelGen").GetComponent<LevelGenerator>();
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
        if (collision.gameObject.CompareTag("Player"))
        {
            LevelGenerator.GameOver();
        }
    }
}