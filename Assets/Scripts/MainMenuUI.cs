using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public GameObject panelMainMenu;
    public GameObject panelNewGame;
    public GameObject panelLoadGame;
    public void NewGame()
    {
        //Ask for a new profile to be created
        //Launch first cinematic
        //Launch into Scene - Machine
        Debug.Log("NewGame");
    }
    public void LoadGame()
    {
        //We should load the next UI panel to load the saved profiles
        //Launch into Scene - Machine
        SceneManager.LoadScene("SampleScene");
        
    }

    public void ExitGame()
    {
        //This works only when built (exe) not on unity. Uncomment when building
        //Application.Quit();
        Debug.Log("Application.Quit()");
    }
}
