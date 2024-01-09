
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollected : MonoBehaviour
{
    public DataController data;
    //
    public int id;//puede servir como identificador
    public bool collected;// = data.datos.coinCollected;//texto de ejemplo aqui debemos sacar la info del objeto del html

    private void Start()
    {
        if(collected)
        {
            //deshabilitar el objeto, para que este no sea obtenido
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject);
        }
    }

    //Esta función es para cuando el objeto ha sido obtenido
    //Aqui la variable collected debe cambiar a true
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collected = true;
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject,0.5f);
        }
    }

}
