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

    void Start()
    {
        enemy = GameObject.Find("Enemy");
    }
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(forwardInput * Vector3.forward * Time.deltaTime * speed, Space.World);
        transform.Translate(horizontalInput * Vector3.right * Time.deltaTime * speed, Space.World);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            LevelGenerator.enemyCount--;
        }
    }
}
