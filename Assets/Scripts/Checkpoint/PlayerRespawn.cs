using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private float checkpointPosX, checkpointPosY;


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("checkpointPosX") !=0)
        {
            transform.position = new Vector2(PlayerPrefs.GetFloat("checkpointPosX"), PlayerPrefs.GetFloat("checkpointPosY"));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ReachedCheckpoint(float x,float y)
    {
        PlayerPrefs.SetFloat("checkpointPosX", x);
        PlayerPrefs.SetFloat("checkpointPosY", y);
    }

}
