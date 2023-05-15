using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Movement : MonoBehaviour
{
    private float speed = 10.0f;
    private float horizontalInput;
    private float forwardInput;
    public GameObject enemy;
    private GameManager gameManager;

    void Start()
    {
        enemy = GameObject.Find("Enemy");
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        // gets the player input
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(forwardInput * Vector3.forward * Time.deltaTime * speed, Space.World);
        // moves the player
        transform.Translate(horizontalInput * Vector3.right * Time.deltaTime * speed, Space.World);
    }

    private void OnTriggerEnter(Collider collision)
    { 
        // if the enemy hits the player game over is triggered
        //Debug.Log("collision");
        //Debug.Log("Collision tag is: " + collision.tag);
        if (collision.tag == "Enemy")
        {
            Debug.Log("Game over!");
            gameManager.GameOver();
        }
    }
}
