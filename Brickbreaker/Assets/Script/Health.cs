using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public int health;

    private void Awake()
    {
        GameManager.brickCount++;
        print(GameManager.brickCount);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health--;
        
        //if our health gets to zero then destroy
        if (health <= 0)
        {
            
            GameManager.brickCount--;
            print(GameManager.brickCount);
            
            if(GameManager.brickCount == 0)
            {
                FindObjectOfType<GameManager>().LoadNextLevel();
            }
            Destroy(gameObject);
        }
    }
}
