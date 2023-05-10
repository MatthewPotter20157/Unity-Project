using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody bulletRb;
    public float bulletSpeed = 20f;
    public GameObject player;
    public Vector3 mousePosition;
    // Start is called before the first frame update
    void Start()
    {
        bulletRb = GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Player");
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
        float xcomponent = Mathf.Cos(angle * Mathf.PI / 180) * force;
        float zcomponent = Mathf.Sin(angle * Mathf.PI / 180) * force;
        bulletRb.AddForce(mousePosition);
        bulletRb.AddForce(Vector3.forward * bulletSpeed);
    }
}
