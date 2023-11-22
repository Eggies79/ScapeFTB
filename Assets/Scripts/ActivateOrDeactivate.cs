using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOrDeactivate : MonoBehaviour
{
    public GameObject _platform;
    public bool activate=true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision)
        {
            if(activate)
            {
                _platform.gameObject.SetActive(true);
            }
            else
            {
                _platform.gameObject.SetActive(false);
            }
            
            //inDoor = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (activate)
        {
            _platform.gameObject.SetActive(false);
        }
        else { _platform.gameObject.SetActive(true);}
    }
}
