using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartButton : MonoBehaviour
{
    private GameManager gameManager;
    //public Button button;
    //Start is called before the first frame update
    void Start()
    {
        //Button play = button.GetComponent<Button>();
        //play.onClick.AddListener(StartGame);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        gameManager.GameStart();
    }
}
