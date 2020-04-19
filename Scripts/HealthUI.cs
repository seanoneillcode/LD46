using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
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
        int current = gameController.peopleContainer.childCount + gameController.buildingContainer.childCount;
        int total = gameController.startingBuilding + gameController.startingPeople;
        text.text = "" + current + "/" + total;
    }
}
