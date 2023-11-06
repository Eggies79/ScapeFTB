using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private PlatformEffector2D effector;

    public float waitTime = 0.5f;
    public float waitedTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /* Some QoL for the platform, still testing
        if (Input.GetKeyUp("s"))
        {
            waitedTime = waitTime;
        }
        */
        
        if (Input.GetKey("s"))
        {
            if(waitedTime <= 0)
            {
                effector.rotationalOffset = 180f;
                waitedTime = waitTime;
            }
            else
            {
                waitedTime -= Time.deltaTime;
            }
        }

        if (Input.GetKey("space"))
        {
            effector.rotationalOffset = 0f;
        }
    }
}
