using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampSupport : MonoBehaviour
{
    private float moveSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Test Hello World");
        //transform.Translate(5, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //if the player presses up arrow,
        //we move the square up.
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(moveSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-moveSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, moveSpeed, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -moveSpeed, 0);
        }
        //Debug.Log("UPDATE METHOD!");
    }
}
