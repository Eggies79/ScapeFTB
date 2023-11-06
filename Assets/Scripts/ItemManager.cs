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
    public void AllItemsCollected()
    {
        if(transform.childCount == 1)
        {
            Debug.Log("All items collected");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
