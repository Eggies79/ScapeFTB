using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemManager : MonoBehaviour
{

    private int itemsInlevel;

    private void Start()
    {
        itemsInlevel = transform.childCount;
    }

    private void Update()
    {
        AllItemsCollected();
    }
    public void AllItemsCollected()
    {
        if(transform.childCount == 0)
        {
            Debug.Log("All items collected");
            SceneManager.LoadScene("00_MainHall");
        }
    }
}
