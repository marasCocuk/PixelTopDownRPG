using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    private List<IDataPersistance> dataPersistanceObjects;

    private GameData gameData;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one Gamemanagers");
        }
        instance = this;

        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(2);
    }

    public void NewGame()
    {
        this.gameData = new GameData();
    }

    public void LoadGame()
    {
        // This will load data from a file
    }

    public void SaveGame()
    {
        //this will save the data to a game file
    }
}