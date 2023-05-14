using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    public NavMeshAgent agent;
    public GameObject bullet;
    private GameManager gameManager;
    void Start()
    {
        player = GameObject.Find("Player");
        bullet = GameObject.Find("Bullet");
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
        gameObject.SetActive(true);
        agent.SetDestination(player.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collisoin happened");
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            GameManager.enemyCount--;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.GameOver();
        }
    }
}