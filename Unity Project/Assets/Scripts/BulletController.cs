using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    LevelGenerator levelGenerator;
    private Rigidbody bulletRb;
    public float bulletSpeed = 20;
    public GameObject player;
    public Vector3 mousePosition;
    public GameObject[] walls;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        bulletRb = GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Player");
        enemy = GameObject.Find("Enemy");
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log(mousePosition);
        AddForceAtAngle(bulletSpeed, player.transform.rotation.y);
        if (Mathf.Abs(gameObject.transform.position.x) > 32 || Mathf.Abs(gameObject.transform.position.z) > 32)
        {
            Destroy(gameObject);
        }
    }

    public void AddForceAtAngle(float force, float angle)
    {
        // fire the bullet towards the mouse position
        float xcomponent = Mathf.Cos(angle * Mathf.PI / 180) * force;
        float zcomponent = Mathf.Sin(angle * Mathf.PI / 180) * force;
        bulletRb.AddForce(mousePosition);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Attack.bulletCount--;
        }
    }
}
