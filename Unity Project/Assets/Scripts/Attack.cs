using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Debug.Log(mousePosition);
        //mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        
        Vector3 direction = new Vector3(mousePosition.x - transform.position.x, 0, mousePosition.z - transform.position.z);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
