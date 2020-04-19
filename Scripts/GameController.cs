using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public float levelTimeSeconds;
    public Transform peopleContainer;
    public Transform buildingContainer;

    public float secondsLeft;

    public int startingPeople;
    public int startingBuilding;

    public bool gameIsWon;
    public string nextLevelName;
    private bool gameResolved;

    // Start is called before the first frame update
    void Start()
    {
        secondsLeft = levelTimeSeconds;
        if (peopleContainer != null)
        {
            startingPeople = peopleContainer.childCount;
        }
        if (buildingContainer != null)
        {
            startingBuilding = buildingContainer.childCount;
        }
    }


    // Update is called once per frame
    void Update()
    {
        secondsLeft -= Time.deltaTime;
        if (!gameResolved && secondsLeft < 0)
        {
            EndGame();
        }

        if (Input.GetButtonDown("Escape"))
        {
            if (SceneManager.GetActiveScene().name.Equals("Start"))
            {
                Quit();
            } else
            {
                LoadMainMenu();
            }
        }
    }

    public void EndGame()
    {
        gameIsWon = peopleContainer.childCount > 0 || buildingContainer.childCount > 0;
        gameResolved = true;
    }

    public bool IsEveryThingDead()
    {
        return peopleContainer.childCount == 0 && buildingContainer.childCount == 0;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void NewGame()
    {
        SceneManager.LoadScene("LevelOne", LoadSceneMode.Single);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(nextLevelName, LoadSceneMode.Single);

    }

    public void RestartCurrentLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }


}
