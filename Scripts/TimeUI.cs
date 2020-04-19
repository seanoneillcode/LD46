using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUI : MonoBehaviour
{
    public GameController gameController;

    private Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.secondsLeft > -1)
        {
            
        text.text = "Time:" + Mathf.FloorToInt(gameController.secondsLeft) + " ";
        }
    }
}
