using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using JetBrains.Annotations;

public class DataController : MonoBehaviour
{
    
    public string saveDataLocation;

    public GameData gameData = new GameData();

    public GameData datos = new GameData();

    private int[] levelAttempts = new int[5];

    private void Start()
    {
        levelAttempts[0] = 0;
        levelAttempts[1] = 2;
        levelAttempts[2] = 0;
        levelAttempts[3] = 2;
        levelAttempts[4] = 1;
    }
    private void Awake()
    {
        saveDataLocation = Application.dataPath + "/savedataSFTB.json";
        //coin = GameObject.find

    }

    private void Update()
    {
        if (Input.GetKeyDown("l"))
        {
            loadGameData();
        }
        if(Input.GetKeyDown("g"))
        {
            saveGameData();
        }
    }

    private void loadGameData()
    {
        if (File.Exists(saveDataLocation))
        {
            string content = File.ReadAllText(saveDataLocation);
            gameData = JsonUtility.FromJson<GameData>(content);
            levelAttempts[0] = gameData.levelAttempts[0];
            levelAttempts[1] = gameData.levelAttempts[1];
            levelAttempts[2] = gameData.levelAttempts[2];
            levelAttempts[3] = gameData.levelAttempts[3];
            levelAttempts[4] = gameData.levelAttempts[4];
            //Debug.Log(gameData.coinCollected);
        }
        else
        {
            Debug.Log("There is no saved data");
        }
    }

    private void saveGameData()
    {
        GameData newData = new GameData()
        {
           levelAttempts = levelAttempts,
            
        };

        string JSONstring = JsonUtility.ToJson(newData);

        File.WriteAllText(saveDataLocation, JSONstring);

        Debug.Log("saved succesfully");
    }

    public void enterDoor(int doorNumber)
    {
        levelAttempts[doorNumber]++;
    }

}
