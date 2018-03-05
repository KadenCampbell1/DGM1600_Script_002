﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]
public class PlayerMovement : MonoBehaviour {


    private Rigidbody2D rigid;
    public float speed;
    private Animator anim;
    private SpriteRenderer rend;

	// Use this for initialization
	void Start ()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //check for button pushes

        rigid.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") *speed), ForceMode2D.Force);
        //to cast as an integer put (int) in front of Input
        anim.SetFloat("HorizontalGo", Input.GetAxisRaw("Horizontal"));

        if(Input.GetAxisRaw("Horizontal") < -0.1f)
        {
            //flip sprite renderer
            rend.flipX = true;
        }
        else
        {
            //unflip
            rend.flipX = false;
        }

	}
}