using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballMove : MonoBehaviour
{
    public GameObject start;
    public GameObject end;
    public float speed = 2.2f;
    private Rigidbody2D rb2d;
    private Animator anim;
    private Transform currentPosition;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        currentPosition = end.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPosition.position - transform.position;
        if(currentPosition == end.transform)
        {
            rb2d.velocity = new Vector2(0,speed);
        }
        else
        {
            rb2d.velocity = new Vector2(0, -speed);
        }
        if(Vector2.Distance(transform.position, currentPosition.position) < 0.5f && currentPosition == end.transform)
        {
            currentPosition = start.transform;
        }
        if (Vector2.Distance(transform.position, currentPosition.position) < 0.5f && currentPosition == start.transform)
        {
            currentPosition = end.transform;
        }
    }
}
