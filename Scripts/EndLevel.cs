using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public GameObject winMenu;
    public GameObject loseMenu;
    public GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.secondsLeft < 0)
        {
            if (gameController.gameIsWon)
            {
                winMenu.SetActive(true);

            } else
            {
                loseMenu.SetActive(true);

            }
        }
    }
}
