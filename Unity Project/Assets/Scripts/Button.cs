using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    //private GameManager gameManager;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        Button play = button.GetComponent<Button>();
        //play.onClick.AddListener(StartGame);
        //gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartGame()
    {
        //gameManager.GameStart();
    }
}
