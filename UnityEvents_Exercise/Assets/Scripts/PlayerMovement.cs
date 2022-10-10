using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    //--------------DECLARING NECESSARY VARIABLES------------------------------------------------------------------------------------
    
    private Rigidbody2D _rb2d;

    private Vector2 _direction;
    private Vector2 _orientation;

    public float _runSpeed = 10f;

    
    //--------------START, UPDATE & FIXEDUPDATE------------------------------------------------------------------------------------


    void Start()
    {
        // set up Rigidbody for use in the script
        _rb2d = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        _direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    private void FixedUpdate()
    {
        _rb2d.velocity = _direction * _runSpeed;
    }

}
