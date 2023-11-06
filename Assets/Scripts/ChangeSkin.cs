using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkin : MonoBehaviour
{
    public GameObject skinsPanel;

    private bool inDoor;

    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            skinsPanel.gameObject.SetActive(true);
            inDoor = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        skinsPanel.gameObject.SetActive(false);
        inDoor = false;
    }
    public void setPlayerAstronaut()
    {
        PlayerPrefs.SetString("PlayerSelected", "Astronaut");
        resetPlayerSkin();
    }

    public void setPlayerSCP()
    {
        PlayerPrefs.SetString("PlayerSelected", "SCP");
        resetPlayerSkin();
    }

    void resetPlayerSkin()
    {
        skinsPanel.gameObject.SetActive(false );
        player.GetComponent<PlayerSelect>().ChangePlayerInMenu();
    }
}
