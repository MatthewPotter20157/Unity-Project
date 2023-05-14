using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    private LevelGenerator levelGenerator;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onCLick.AddListener(StartGame);
        levelGenerator = GameObject.Find("LevelGen").GetComponent<LevelGenerator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
        levelGenerator.GameStart();
    }
}
