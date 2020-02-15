﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // distance moved when user holds up or down arrow keys 
    public float turnSpeed = 60f; //roatating speed when user holds left or right arrow key 
    public float jumpHeight = 5f; // upward velocity when user presses spacebar

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // check up and down arrow keys to move forwards and backwards 
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            this.transform.position += this.transform.forward * Time.deltaTime * this.moveSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            this.transform.position -= this.transform.forward * Time.deltaTime * this.moveSpeed;
        }

        // check left and right arrow keys to rotate left and right 
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            this.transform.Rotate(this.transform.up, Time.deltaTime * -this.turnSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            this.transform.Rotate(this.transform.up, Time.deltaTime * this.turnSpeed);
        }

        // Check spacebar to trigger jumping. Checks if vertical velocity (eg velocity.y) is near to zero.
        if (Input.GetKey(KeyCode.Space) == true && Mathf.Abs(this.GetComponent<Rigidbody>().velocity.y) < 0.01f)
        {
            this.GetComponent<Rigidbody>().velocity += Vector3.up * this.jumpHeight;
        }
    }
}
