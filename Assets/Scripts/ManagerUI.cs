using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerUI : MonoBehaviour
{
    public GameObject panelOptions;
    public GameObject panelSkins;
    public GameObject player;
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

    public void ChangeSkin()
    {
        panelOptions.SetActive(false);
        panelSkins.SetActive(true);
    }

    public void setPlayerAstro()
    {
        PlayerPrefs.SetString("PlayerSelected", "Astro");
        resetPlayerSkin();
    }

    public void setPlayerBolo()
    {
        PlayerPrefs.SetString("PlayerSelected", "Bolo");
        resetPlayerSkin();
    }

    public void setPlayerRed()
    {
        PlayerPrefs.SetString("PlayerSelected", "Red");
        resetPlayerSkin();
    }

    void resetPlayerSkin()
    {
        Time.timeScale = 1;
        panelSkins.gameObject.SetActive(false);
        player.GetComponent<PlayerSelect>().ChangePlayerInMenu();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
