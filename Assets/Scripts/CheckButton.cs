using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckButton : MonoBehaviour
{
    public static bool inButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inButton = true;
            Debug.Log("IN");
        }
        else
        {
            inButton = false;
            Debug.Log("OUT");
        }


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        inButton = false;
        Debug.Log("OUT");
    }
}