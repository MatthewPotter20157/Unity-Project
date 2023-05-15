using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    // makes the enemy a nav mesh agent so it can find the fastest path to the player
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
        // every update the enemys destination is set to the player
        agent.SetDestination(player.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // if the enemy collides with a bullet it gets distroied
        Debug.Log("collisoin happened");
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            // lowers the enemy count so the game manager knows when to spawn the next wave
            GameManager.enemyCount--;
        }
    }
}