using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartButton : MonoBehaviour
{
    private GameManager gameManager;
    //Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        // starts the game
        gameManager.GameStart();
    }
}
