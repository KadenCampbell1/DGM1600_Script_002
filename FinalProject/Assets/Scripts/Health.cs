using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health;
    

    public void IncrementHealth(int amount)
    {
        health += amount;
        if (health <= 0)
        {
            //do something
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
    
}
