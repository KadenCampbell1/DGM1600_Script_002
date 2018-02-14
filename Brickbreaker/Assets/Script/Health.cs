﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public int health;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health--;
        
        //if our health gets to zero then destroy
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}