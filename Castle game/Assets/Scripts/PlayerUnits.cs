using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnits : MonoBehaviour
{
    GameObject playerUnits;
    GameObject enemyUnits;
    private Vector3 playerUnitFollow;
    // Start is called before the first frame update
    void Start()
    {
        playerUnits = GameObject.FindWithTag("PLayerUnits");
        enemyUnits = GameObject.FindWithTag("EnemyUnits");
    }

    // Update is called once per frame
    void Update()
    {
        playerUnitFollow = new Vector3(0, 0, 1);
        transform.Translate(0, 0, 1);
    }
    
}
