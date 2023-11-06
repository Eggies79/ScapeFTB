using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerUI : MonoBehaviour
{
    public GameObject panelOptions;
    public void PanelOptions()
    {
        Time.timeScale = 0;
        panelOptions.SetActive(true);

    }

    public void ReturnToGame()
    {
        Time.timeScale = 1;
        panelOptions.SetActive(false);
    }

    public void ExitLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
    public void ExitMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame()
    {
        //This works only when built aka (exe) not on unity. Uncomment when building
        //Application.Quit();
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }


}
