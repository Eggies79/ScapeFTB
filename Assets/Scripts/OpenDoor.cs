using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{

    //door to travel between levels
    public string levelName;
    private bool inDoor = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        inDoor = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        inDoor = false;
    }

    private void Update()
    {
        if (inDoor && Input.GetKey("e"))
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
