using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool isGrounded;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            isGrounded = true;
            //Debug.Log("Grounded");
        }
        else
        {
            isGrounded = false;
            //Debug.Log("Airborne");
        }

        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded= false;
        //Debug.Log("Airborne");
    }
}
