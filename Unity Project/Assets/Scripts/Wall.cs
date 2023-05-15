using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public static float wallsDestroyed = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        // if the wall is clicked the walls get distroied
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
            wallsDestroyed = 1;
        }
    }
}
