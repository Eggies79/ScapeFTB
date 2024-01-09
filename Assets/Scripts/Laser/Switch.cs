using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour
{
    public GameObject shortLaser;
    public GameObject longLaser;
    private bool laserState = false;
    private bool onButton = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        onButton = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        onButton = false;
    }

    private void Start()
    {
        shortLaser.SetActive(laserState);
    }
    private void Update()
    {
        if (onButton && Input.GetKeyDown("e"))
        {
            laserState = !laserState;
            shortLaser.SetActive(laserState);
        }
    }

}
