using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    bool canMove = true; 
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 20f;
    [SerializeField] float defaultSpeed = 10f;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
        Cursor.visible = false;
    }

    
    void Update()
    {
        if(canMove)
        {
            RotatePlayer();
            BoostPlayer();
        }
        
    }

    public void DisableControls()
    {
        canMove = false;
    }

    void BoostPlayer()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = defaultSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount * Time.deltaTime);
        }
    }
}
